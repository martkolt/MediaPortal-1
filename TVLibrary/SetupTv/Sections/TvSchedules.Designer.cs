namespace SetupTv.Sections
{
  partial class TvSchedules
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TvSchedules));
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addSCheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.mpButton1 = new MediaPortal.UserInterface.Controls.MPButton();
      this.listView1 = new System.Windows.Forms.ListView();
      this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.PreRecord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.PostRecord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.EpisodesToKeep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.mpButtonDel = new MediaPortal.UserInterface.Controls.MPButton();
      this.mpLabelChannelCount = new MediaPortal.UserInterface.Controls.MPLabel();
      this.Programs = new System.Windows.Forms.TabPage();
      this.mpLabel2 = new MediaPortal.UserInterface.Controls.MPLabel();
      this.comboBoxGroups = new SetupControls.ComboBoxEx();
      this.comboBoxChannels = new MediaPortal.UserInterface.Controls.MPComboBox();
      this.mpLabel1 = new MediaPortal.UserInterface.Controls.MPLabel();
      this.label25 = new System.Windows.Forms.Label();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.listView2 = new System.Windows.Forms.ListView();
      this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.contextMenuStrip1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.Programs.SuspendLayout();
      this.SuspendLayout();
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "tvguide_recordserie_button.png");
      this.imageList1.Images.SetKeyName(1, "tvguide_record_button.png");
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem, this.addSCheduleToolStripMenuItem,
            this.toolStripMenuItem1});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(108, 32);
      // 
      // deleteToolStripMenuItem
      // 
      this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
      this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
      this.deleteToolStripMenuItem.Text = "Delete";
      this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);

      // 
      // deleteToolStripMenuItem
      // 
      this.addSCheduleToolStripMenuItem.Name = "addSCheduleToolStripMenuItem";
      this.addSCheduleToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
      this.addSCheduleToolStripMenuItem.Text = "Add schedule";
      this.addSCheduleToolStripMenuItem.Click += new System.EventHandler(this.addScheduleToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(104, 6);
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.Programs);
      this.tabControl1.Location = new System.Drawing.Point(3, 3);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(881, 414);
      this.tabControl1.TabIndex = 9;
      this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.mpButton1);
      this.tabPage1.Controls.Add(this.listView1);
      this.tabPage1.Controls.Add(this.mpButtonDel);
      this.tabPage1.Controls.Add(this.mpLabelChannelCount);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(873, 388);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Schedules";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // mpButton1
      // 
      this.mpButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.mpButton1.Location = new System.Drawing.Point(116, 359);
      this.mpButton1.Name = "mpButton1";
      this.mpButton1.Size = new System.Drawing.Size(55, 23);
      this.mpButton1.TabIndex = 4;
      this.mpButton1.Text = "test";
      this.mpButton1.UseVisualStyleBackColor = true;
      this.mpButton1.Click += new System.EventHandler(this.mpButton1_Click);
      // 
      // listView1
      // 
      this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3,
            this.PreRecord,
            this.PostRecord,
            this.EpisodesToKeep});
      this.listView1.ContextMenuStrip = this.contextMenuStrip1;
      this.listView1.FullRowSelect = true;
      this.listView1.LargeImageList = this.imageList1;
      this.listView1.Location = new System.Drawing.Point(9, 11);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(858, 348);
      this.listView1.SmallImageList = this.imageList1;
      this.listView1.TabIndex = 3;
      this.listView1.UseCompatibleStateImageBehavior = false;
      this.listView1.View = System.Windows.Forms.View.Details;
      this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
      // 
      // columnHeader5
      // 
      this.columnHeader5.Text = "Priority";
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Channel";
      // 
      // columnHeader4
      // 
      this.columnHeader4.Text = "Type";
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Date";
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Title";
      // 
      // PreRecord
      // 
      this.PreRecord.Text = "PreRecord";
      // 
      // PostRecord
      // 
      this.PostRecord.Text = "PostRecord";
      // 
      // EpisodesToKeep
      // 
      this.EpisodesToKeep.Text = "Episodes to keep";
      // 
      // mpButtonDel
      // 
      this.mpButtonDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.mpButtonDel.Location = new System.Drawing.Point(9, 365);
      this.mpButtonDel.Name = "mpButtonDel";
      this.mpButtonDel.Size = new System.Drawing.Size(55, 23);
      this.mpButtonDel.TabIndex = 1;
      this.mpButtonDel.Text = "Delete";
      this.mpButtonDel.UseVisualStyleBackColor = true;
      this.mpButtonDel.Click += new System.EventHandler(this.mpButtonDel_Click);
      // 
      // mpLabelChannelCount
      // 
      this.mpLabelChannelCount.AutoSize = true;
      this.mpLabelChannelCount.Location = new System.Drawing.Point(13, 14);
      this.mpLabelChannelCount.Name = "mpLabelChannelCount";
      this.mpLabelChannelCount.Size = new System.Drawing.Size(0, 13);
      this.mpLabelChannelCount.TabIndex = 2;
      // 
      // Programs
      // 
      this.Programs.Controls.Add(this.mpLabel2);
      this.Programs.Controls.Add(this.comboBoxGroups);
      this.Programs.Controls.Add(this.comboBoxChannels);
      this.Programs.Controls.Add(this.mpLabel1);
      this.Programs.Controls.Add(this.label25);
      this.Programs.Controls.Add(this.dateTimePicker1);
      this.Programs.Controls.Add(this.listView2);
      this.Programs.Location = new System.Drawing.Point(4, 22);
      this.Programs.Name = "Programs";
      this.Programs.Padding = new System.Windows.Forms.Padding(3);
      this.Programs.Size = new System.Drawing.Size(873, 388);
      this.Programs.TabIndex = 1;
      this.Programs.Text = "Programs";
      this.Programs.UseVisualStyleBackColor = true;
      // 
      // mpLabel2
      // 
      this.mpLabel2.AutoSize = true;
      this.mpLabel2.Location = new System.Drawing.Point(316, 9);
      this.mpLabel2.Name = "mpLabel2";
      this.mpLabel2.Size = new System.Drawing.Size(39, 13);
      this.mpLabel2.TabIndex = 63;
      this.mpLabel2.Text = "Group:";
      // 
      // comboBoxGroups
      // 
      this.comboBoxGroups.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.comboBoxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxGroups.FormattingEnabled = true;
      this.comboBoxGroups.ImageList = this.imageList1;
      this.comboBoxGroups.Location = new System.Drawing.Point(366, 6);
      this.comboBoxGroups.Name = "comboBoxGroups";
      this.comboBoxGroups.Size = new System.Drawing.Size(151, 21);
      this.comboBoxGroups.TabIndex = 62;
      this.comboBoxGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroups_SelectedIndexChanged);
      // 
      // comboBoxChannels
      // 
      this.comboBoxChannels.FormattingEnabled = true;
      this.comboBoxChannels.Location = new System.Drawing.Point(578, 6);
      this.comboBoxChannels.Name = "comboBoxChannels";
      this.comboBoxChannels.Size = new System.Drawing.Size(121, 21);
      this.comboBoxChannels.TabIndex = 58;
      this.comboBoxChannels.SelectedIndexChanged += new System.EventHandler(this.mpComboBox1_SelectedIndexChanged);
      // 
      // mpLabel1
      // 
      this.mpLabel1.AutoSize = true;
      this.mpLabel1.Location = new System.Drawing.Point(523, 8);
      this.mpLabel1.Name = "mpLabel1";
      this.mpLabel1.Size = new System.Drawing.Size(49, 13);
      this.mpLabel1.TabIndex = 57;
      this.mpLabel1.Text = "Channel:";
      // 
      // label25
      // 
      this.label25.AutoSize = true;
      this.label25.Location = new System.Drawing.Point(6, 12);
      this.label25.Name = "label25";
      this.label25.Size = new System.Drawing.Size(98, 13);
      this.label25.TabIndex = 9;
      this.label25.Text = "Show programs for:";
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(110, 6);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
      this.dateTimePicker1.TabIndex = 5;
      this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
      // 
      // listView2
      // 
      this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
      this.listView2.ContextMenuStrip = this.contextMenuStrip1;
      this.listView2.FullRowSelect = true;
      this.listView2.LargeImageList = this.imageList1;
      this.listView2.Location = new System.Drawing.Point(8, 51);
      this.listView2.Name = "listView2";
      this.listView2.Size = new System.Drawing.Size(844, 317);
      this.listView2.SmallImageList = this.imageList1;
      this.listView2.TabIndex = 4;
      this.listView2.UseCompatibleStateImageBehavior = false;
      this.listView2.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader6
      // 
      this.columnHeader6.Text = "Title";
      // 
      // columnHeader7
      // 
      this.columnHeader7.Text = "Start";
      // 
      // columnHeader8
      // 
      this.columnHeader8.Text = "End";
      // 
      // columnHeader9
      // 
      this.columnHeader9.Text = "Description";
      // 
      // columnHeader10
      // 
      this.columnHeader10.Text = "Series#";
      // 
      // columnHeader11
      // 
      this.columnHeader11.Text = "Episode#";
      // 
      // columnHeader12
      // 
      this.columnHeader12.Text = "Genre";
      // 
      // columnHeader13
      // 
      this.columnHeader13.Text = "Orig.Air Date";
      // 
      // columnHeader14
      // 
      this.columnHeader14.Text = "Classification";
      // 
      // columnHeader15
      // 
      this.columnHeader15.Text = "StarRating";
      // 
      // columnHeader16
      // 
      this.columnHeader16.Text = "ParentalRating";
      // 
      // columnHeader17
      // 
      this.columnHeader17.Text = "EpisodeName";
      // 
      // columnHeader18
      // 
      this.columnHeader18.Text = "EpisodePart";
      // 
      // columnHeader19
      // 
      this.columnHeader19.Text = "State";
      // 
      // TvSchedules
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tabControl1);
      this.Name = "TvSchedules";
      this.Size = new System.Drawing.Size(887, 419);
      this.contextMenuStrip1.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.Programs.ResumeLayout(false);
      this.Programs.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addSCheduleToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.ColumnHeader columnHeader5;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader PreRecord;
    private System.Windows.Forms.ColumnHeader PostRecord;
    private MediaPortal.UserInterface.Controls.MPLabel mpLabelChannelCount;
    private MediaPortal.UserInterface.Controls.MPButton mpButtonDel;
    private System.Windows.Forms.ColumnHeader EpisodesToKeep;
    private System.Windows.Forms.TabPage Programs;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.ListView listView2;
    private System.Windows.Forms.ColumnHeader columnHeader6;
    private System.Windows.Forms.ColumnHeader columnHeader7;
    private System.Windows.Forms.ColumnHeader columnHeader8;
    private System.Windows.Forms.ColumnHeader columnHeader9;
    private System.Windows.Forms.ColumnHeader columnHeader10;
    private System.Windows.Forms.ColumnHeader columnHeader11;
    private System.Windows.Forms.ColumnHeader columnHeader12;
    private System.Windows.Forms.ColumnHeader columnHeader13;
    private System.Windows.Forms.Label label25;
    private System.Windows.Forms.ColumnHeader columnHeader14;
    private System.Windows.Forms.ColumnHeader columnHeader15;
    private System.Windows.Forms.ColumnHeader columnHeader16;
    private System.Windows.Forms.ColumnHeader columnHeader17;
    private System.Windows.Forms.ColumnHeader columnHeader18;
    private System.Windows.Forms.ColumnHeader columnHeader19;
    private MediaPortal.UserInterface.Controls.MPComboBox comboBoxChannels;
    private MediaPortal.UserInterface.Controls.MPLabel mpLabel1;
    private SetupControls.ComboBoxEx comboBoxGroups;
    private MediaPortal.UserInterface.Controls.MPLabel mpLabel2;
    private MediaPortal.UserInterface.Controls.MPButton mpButton1;
  }
}