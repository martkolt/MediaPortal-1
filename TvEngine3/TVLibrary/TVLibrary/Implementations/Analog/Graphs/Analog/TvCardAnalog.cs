/* 
 *	Copyright (C) 2005-2006 Team MediaPortal
 *	http://www.team-mediaportal.com
 *
 *  This Program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2, or (at your option)
 *  any later version.
 *   
 *  This Program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 *  GNU General Public License for more details.
 *   
 *  You should have received a copy of the GNU General Public License
 *  along with GNU Make; see the file COPYING.  If not, write to
 *  the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA. 
 *  http://www.gnu.org/copyleft/gpl.html
 *
 */
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.Text;
using DirectShowLib;
using TvLibrary.Implementations;
using DirectShowLib.SBE;
using TvLibrary.Log;
using TvLibrary.Interfaces;
using TvLibrary.Teletext;
using TvLibrary.Epg;
using TvLibrary.Implementations.DVB;
using TvLibrary.Helper;

namespace TvLibrary.Implementations.Analog
{
  /// <summary>
  /// Implementation of <see cref="T:TvLibrary.Interfaces.ITVCard"/> which handles analog tv cards
  /// </summary>
  public class TvCardAnalog : TvCardAnalogBase, IDisposable, ITVCard, ISampleGrabberCB
  {
    AnalogChannel _previousChannel;
    #region ctor

    /// <summary>
    /// Initializes a new instance of the <see cref="TvCardAnalog"/> class.
    /// </summary>
    /// <param name="device">The device.</param>
    public TvCardAnalog(DsDevice device)
    {
      _previousChannel = null;
      _tunerDevice = device;
      _name = device.Name;
      _graphState = GraphState.Idle;
      _teletextDecoder = new DVBTeletext();
    }
    #endregion


    #region properties
    /// <summary>
    /// Gets/sets the card name
    /// </summary>
    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        _name = value;
      }
    }

    /// <summary>
    /// gets the current filename used for recording
    /// </summary>
    public string FileName
    {
      get
      {
        return _recordingFileName;
      }
    }

    /// <summary>
    /// returns true if card is currently recording
    /// </summary>
    public bool IsRecording
    {
      get
      {
        return (_graphState == GraphState.Recording);
      }
    }

    /// <summary>
    /// returns true if card is currently timeshifting
    /// </summary>
    public bool IsTimeShifting
    {
      get
      {
        return (_graphState == GraphState.TimeShifting);
      }
    }

    /// <summary>
    /// returns the IChannel to which the card is currently tuned
    /// </summary>
    public IChannel Channel
    {
      get
      {
        return _currentChannel;
      }
    }
    #endregion

    #region epg & scanning
    /// <summary>
    /// returns the ITVScanning interface used for scanning channels
    /// </summary>
    public ITVScanning ScanningInterface
    {
      get
      {
        return new AnalogScanning(this);
      }
    }
    /// <summary>
    /// returns the ITVEPG interface used for grabbing the epg
    /// </summary>
    public ITVEPG EpgInterface
    {
      get
      {
        return null;
      }
    }
 
    /// <summary>
    /// Returns the EPG grabbed or null if epg grabbing is still busy
    /// </summary>
    public List<EpgChannel> Epg
    {
      get
      {
        return null;
      }
    }
    #endregion

    #region teletext
    /// <summary>
    /// Property which returns true when the current channel contains teletext
    /// </summary>
    /// <value></value>
    public bool HasTeletext
    {
      get
      {
        return (_pinVBI != null);
      }
    }
    /// <summary>
    /// Turn on/off teletext grabbing
    /// </summary>
    public bool GrabTeletext
    {
      get
      {
        return _grabTeletext;
      }
      set
      {
        if (_pinVBI == null)
          _grabTeletext = false;
        else
          _grabTeletext = value;
      }
    }

    /// <summary>
    /// returns the ITeletext interface used for retrieving the teletext pages
    /// </summary>
    public ITeletext TeletextDecoder
    {
      get
      {
        if (_pinVBI == null) return null;
        return _teletextDecoder;
      }
    }
    #endregion

    #region tuning & recording
    /// <summary>
    /// tune the card to the channel specified by IChannel
    /// </summary>
    /// <param name="channel">channel to tune</param>
    /// <returns></returns>
    public bool TuneScan(IChannel channel)
    {
      bool result = Tune(channel);
      return result;
    }
    /// <summary>
    /// Method to check if card can tune to the channel specified
    /// </summary>
    /// <returns>true if card can tune to the channel otherwise false</returns>
    public bool CanTune(IChannel channel)
    {
      if ((channel as AnalogChannel) == null) return false;
      if (channel.IsRadio)
      {
        if (_graphState == GraphState.Idle)
        {
          BuildGraph();
          RunGraph();
        }
        IAMTVTuner tuner = _filterTvTuner as IAMTVTuner;
        AMTunerModeType tunerModes;
        tuner.GetAvailableModes(out tunerModes);
        if ((AMTunerModeType.FMRadio & tunerModes) != 0) return true;
        return false;
      }
      return true;
    }

    /// <summary>
    /// Tunes the specified channel.
    /// </summary>
    /// <param name="channel">The channel.</param>
    /// <returns></returns>
    public bool Tune(IChannel channel)
    {
      Log.Log.WriteFile("analog:  Tune:{0}", channel);
      if (_graphState == GraphState.Idle)
      {
        BuildGraph();
        RunGraph();
      }
      if (!CheckThreadId()) return false;

      AnalogChannel analogChannel = channel as AnalogChannel;
      IAMTVTuner tvTuner = _filterTvTuner as IAMTVTuner;
      if (_previousChannel != null)
      {
        if (_previousChannel.VideoSource != analogChannel.VideoSource)
        {
          SetupCrossBar(analogChannel.VideoSource);
        }
        if (analogChannel.IsRadio != _previousChannel.IsRadio)
        {
          if (analogChannel.IsRadio)
          {
            Log.Log.WriteFile("analog:  set to FM radio");
            tvTuner.put_Mode(AMTunerModeType.FMRadio);
            _pinVideo.Disconnect();
          }
          else
          {
            Log.Log.WriteFile("analog:  set to TV");
            FilterGraphTools.ConnectPin(_graphBuilder, _pinVideo, _filterMpegMuxer, 0);
            tvTuner.put_Mode(AMTunerModeType.TV);
          }
        }
        if (analogChannel.Country.Id != _previousChannel.Country.Id)
        {
          tvTuner.put_TuningSpace(analogChannel.Country.Id);
          tvTuner.put_CountryCode(analogChannel.Country.Id);
        }
        if (analogChannel.TunerSource != _previousChannel.TunerSource)
        {
          tvTuner.put_InputType(0, analogChannel.TunerSource);
        }
        if (analogChannel.IsRadio)
        {
          if (analogChannel.Frequency != _previousChannel.Frequency)
          {
            tvTuner.put_Channel((int)analogChannel.Frequency, AMTunerSubChannel.Default, AMTunerSubChannel.Default);
          }
        }
        else
        {
          if (analogChannel.ChannelNumber != _previousChannel.ChannelNumber)
          {
            tvTuner.put_Channel(analogChannel.ChannelNumber, AMTunerSubChannel.Default, AMTunerSubChannel.Default);
          }
        }
      }
      else
      {
        if (channel.IsRadio)
        {
          Log.Log.WriteFile("analog:  set to FM radio");
          tvTuner.put_Mode(AMTunerModeType.FMRadio);
        }
        else
        {
          Log.Log.WriteFile("analog:  set to TV");
          tvTuner.put_Mode(AMTunerModeType.TV);
        }
        tvTuner.put_TuningSpace(analogChannel.Country.Id);
        tvTuner.put_CountryCode(analogChannel.Country.Id);
        tvTuner.put_InputType(0, analogChannel.TunerSource);
        tvTuner.put_Channel(analogChannel.ChannelNumber, AMTunerSubChannel.Default, AMTunerSubChannel.Default);
        SetupCrossBar(analogChannel.VideoSource);
      }
      if (_teletextDecoder != null)
      {
        _teletextDecoder.ClearBuffer();
        _teletextDecoder.ClearTeletextChannelName();
      }
      int videoFrequency;
      int audioFrequency;
      tvTuner.get_VideoFrequency(out videoFrequency);
      tvTuner.get_AudioFrequency(out audioFrequency);
      _lastSignalUpdate = DateTime.MinValue;
      _tunerLocked = false;
      _currentChannel = analogChannel;
      if (_graphState == GraphState.Idle)
        _graphState = GraphState.Created;
      Log.Log.WriteFile("Analog: Tuned to video:{0} Hz audio:{1} Hz locked:{2}", videoFrequency, audioFrequency, IsTunerLocked);
      _lastSignalUpdate = DateTime.MinValue;
      _previousChannel = analogChannel;
      return true;
    }
    /// <summary>
    /// Gets the video frequency.
    /// </summary>
    /// <value>The video frequency.</value>
    public int VideoFrequency
    {
      get
      {
        IAMTVTuner tvTuner = _filterTvTuner as IAMTVTuner;
        int videoFrequency;
        tvTuner.get_VideoFrequency(out videoFrequency);
        return videoFrequency;
      }
    }
    /// <summary>
    /// Gets the audio frequency.
    /// </summary>
    /// <value>The audio frequency.</value>
    public int AudioFrequency
    {
      get
      {
        IAMTVTuner tvTuner = _filterTvTuner as IAMTVTuner;
        int audioFrequency;
        tvTuner.get_AudioFrequency(out audioFrequency);
        return audioFrequency;
      }
    }

    /// <summary>
    /// Starts timeshifting. Note card has to be tuned first
    /// </summary>
    /// <param name="fileName">filename used for the timeshiftbuffer</param>
    /// <returns></returns>
    public bool StartTimeShifting(string fileName)
    {
      if (!CheckThreadId()) return false;
      Log.Log.WriteFile("Analog: StartTimeShifting()");
      if (_graphState == GraphState.Created)
      {
        string extension = System.IO.Path.GetExtension(fileName).ToLower();
        StopGraph();
        AddMpegMuxer(_currentChannel.IsTv);
        AddTsFileSink(_currentChannel.IsTv);
        
        SetTimeShiftFileName(fileName);
      }
      RunGraph();
      _graphState = GraphState.TimeShifting;
      _lastSignalUpdate = DateTime.MinValue;
      FileAccessHelper.GrantFullControll(fileName);
      _tunerLocked = false;
      return true;
    }

    /// <summary>
    /// Stops timeshifting
    /// </summary>
    /// <returns></returns>
    public bool StopTimeShifting()
    {
      if (!CheckThreadId()) return false;
      Log.Log.WriteFile("Analog: StopTimeShifting()");
      StopGraph();

      DeleteTimeShifting();
      _graphState = GraphState.Created;
      return true;
    }

    /// <summary>
    /// Starts recording
    /// </summary>
    /// <param name="recordingType">Recording type (content or reference)</param>
    /// <param name="fileName">filename to which to recording should be saved</param>
    /// <param name="startTime">time the recording should start (0=now)</param>
    /// <returns></returns>
    public bool StartRecording(RecordingType recordingType, string fileName, long startTime)
    {
      if (!CheckThreadId()) return false;
      Log.Log.WriteFile("Analog:StartRecording to {0}", fileName);

      if (_graphState != GraphState.TimeShifting)
      {
        throw new TvException("Card must be timeshifting before starting recording");
      }

      StartRecord(fileName, recordingType, ref startTime);


      _recordingFileName = fileName;
      Log.Log.WriteFile("Analog:Started recording on {0}", startTime);
      _graphState = GraphState.Recording;
      return true;
    }

    /// <summary>
    /// Stop recording
    /// </summary>
    /// <returns></returns>
    public bool StopRecording()
    {
      if (!CheckThreadId()) return false;
      Log.Log.WriteFile("Analog:StopRecording");
      StopRecord();
      _graphState = GraphState.TimeShifting;
      _recordingFileName = "";
      return true;
    }
    #endregion



    #region quality control
    /// <summary>
    /// Get/Set the quality
    /// </summary>
    public IQuality Quality
    {
      get
      {
        return null;
      }
      set
      {
      }
    }

    /// <summary>
    /// Property which returns true if card supports quality control
    /// </summary>
    public bool SupportsQualityControl
    {
      get
      {
        return false;
      }
    }
    #endregion

    #region properties
    /// <summary>
    /// When the tuner is locked onto a signal this property will return true
    /// otherwise false
    /// </summary>
    public bool IsTunerLocked
    {
      get
      {
        if (_graphState == GraphState.Idle) return false;

        if (!CheckThreadId()) return false;
        //TimeSpan ts = DateTime.Now - _lastSignalUpdate;
        //if (ts.TotalMilliseconds < 1000) return _tunerLocked;
        //_lastSignalUpdate = DateTime.Now;
        IAMTVTuner tvTuner = _filterTvTuner as IAMTVTuner;
        AMTunerSignalStrength signalStrength;
        tvTuner.SignalPresent(out signalStrength);
        _tunerLocked = (signalStrength == AMTunerSignalStrength.SignalPresent);
        return _tunerLocked;
      }
    }

    /// <summary>
    /// returns the signal quality
    /// </summary>
    public int SignalQuality
    {
      get
      {
        if (_graphState == GraphState.Idle) return 0;
        if (!CheckThreadId()) return 0;
        if (IsTunerLocked) return 100;
        return 0;
      }
    }

    /// <summary>
    /// returns the signal level
    /// </summary>
    public int SignalLevel
    {
      get
      {
        if (_graphState == GraphState.Idle) return 0;
        if (!CheckThreadId()) return 0;
        if (IsTunerLocked) return 100;
        return 0;
      }
    }
    #endregion


    /// <summary>
    /// Toes the string.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return _name;
    }

    public void GrabEpg(BaseEpgGrabber callback)
    {
    }

  }
}

