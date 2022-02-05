namespace Colors
{
    partial class ColorPickerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPickerForm));
            this.mnuMenubar = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_New = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFile_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView_Compare = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView_sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuView_Fullscreen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor_Reset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor_Random = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor_Invert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp_Manual = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp_sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelp_About = new System.Windows.Forms.ToolStripMenuItem();
            this.tpnlColorTracks = new System.Windows.Forms.TableLayoutPanel();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.nudGreen = new System.Windows.Forms.NumericUpDown();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.mnuStatusBar = new System.Windows.Forms.StatusStrip();
            this.spnlSplit = new System.Windows.Forms.SplitContainer();
            this.pnlSample1 = new System.Windows.Forms.Panel();
            this.sampleView1 = new Colors.SampleView();
            this.pnlSample2 = new System.Windows.Forms.Panel();
            this.sampleView2 = new Colors.SampleView();
            this.mnuToolbar = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.mnuToolbar_sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.mnuToolbar_sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.btnPaste = new System.Windows.Forms.ToolStripButton();
            this.mnuToolbar_sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCompare = new System.Windows.Forms.ToolStripButton();
            this.mnuToolbar_sep4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReset = new System.Windows.Forms.ToolStripButton();
            this.btnRandom = new System.Windows.Forms.ToolStripButton();
            this.btnInvert = new System.Windows.Forms.ToolStripButton();
            this.mnuToolbar_sep5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tmrParty = new System.Windows.Forms.Timer(this.components);
            this.colorPalette = new Colors.ColorPaletteControl();
            this.mnuMenubar.SuspendLayout();
            this.tpnlColorTracks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnlSplit)).BeginInit();
            this.spnlSplit.Panel1.SuspendLayout();
            this.spnlSplit.Panel2.SuspendLayout();
            this.spnlSplit.SuspendLayout();
            this.pnlSample1.SuspendLayout();
            this.pnlSample2.SuspendLayout();
            this.mnuToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenubar
            // 
            this.mnuMenubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView,
            this.mnuColor,
            this.mnuHelp});
            this.mnuMenubar.Location = new System.Drawing.Point(0, 0);
            this.mnuMenubar.Name = "mnuMenubar";
            this.mnuMenubar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.mnuMenubar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMenubar.Size = new System.Drawing.Size(784, 24);
            this.mnuMenubar.TabIndex = 0;
            this.mnuMenubar.Text = "Menu bar";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile_New,
            this.mnuFile_sep1,
            this.mnuFile_Open,
            this.mnuFile_Save,
            this.mnuFile_sep2,
            this.mnuFile_Exit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 22);
            this.mnuFile.Text = "&File";
            // 
            // mnuFile_New
            // 
            this.mnuFile_New.Image = global::Colors.Properties.Resources.New16;
            this.mnuFile_New.Name = "mnuFile_New";
            this.mnuFile_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFile_New.Size = new System.Drawing.Size(188, 22);
            this.mnuFile_New.Text = "&New Window";
            this.mnuFile_New.Click += new System.EventHandler(this.mnuFile_New_Click);
            // 
            // mnuFile_sep1
            // 
            this.mnuFile_sep1.Name = "mnuFile_sep1";
            this.mnuFile_sep1.Size = new System.Drawing.Size(185, 6);
            // 
            // mnuFile_Open
            // 
            this.mnuFile_Open.Image = global::Colors.Properties.Resources.Open16;
            this.mnuFile_Open.Name = "mnuFile_Open";
            this.mnuFile_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFile_Open.Size = new System.Drawing.Size(188, 22);
            this.mnuFile_Open.Text = "&Open";
            this.mnuFile_Open.Click += new System.EventHandler(this.mnuFile_Open_Click);
            // 
            // mnuFile_Save
            // 
            this.mnuFile_Save.Image = global::Colors.Properties.Resources.Save16;
            this.mnuFile_Save.Name = "mnuFile_Save";
            this.mnuFile_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFile_Save.Size = new System.Drawing.Size(188, 22);
            this.mnuFile_Save.Text = "&Save";
            this.mnuFile_Save.Click += new System.EventHandler(this.mnuFile_Save_Click);
            // 
            // mnuFile_sep2
            // 
            this.mnuFile_sep2.Name = "mnuFile_sep2";
            this.mnuFile_sep2.Size = new System.Drawing.Size(185, 6);
            // 
            // mnuFile_Exit
            // 
            this.mnuFile_Exit.Image = global::Colors.Properties.Resources.X16;
            this.mnuFile_Exit.Name = "mnuFile_Exit";
            this.mnuFile_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuFile_Exit.Size = new System.Drawing.Size(188, 22);
            this.mnuFile_Exit.Text = "E&xit";
            this.mnuFile_Exit.Click += new System.EventHandler(this.mnuFile_Exit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEdit_Copy,
            this.mnuEdit_Paste});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 22);
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuEdit_Copy
            // 
            this.mnuEdit_Copy.Image = global::Colors.Properties.Resources.Copy16;
            this.mnuEdit_Copy.Name = "mnuEdit_Copy";
            this.mnuEdit_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuEdit_Copy.Size = new System.Drawing.Size(144, 22);
            this.mnuEdit_Copy.Text = "&Copy";
            this.mnuEdit_Copy.Click += new System.EventHandler(this.mnuEdit_Copy_Click);
            // 
            // mnuEdit_Paste
            // 
            this.mnuEdit_Paste.Image = global::Colors.Properties.Resources.Paste16;
            this.mnuEdit_Paste.Name = "mnuEdit_Paste";
            this.mnuEdit_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuEdit_Paste.Size = new System.Drawing.Size(144, 22);
            this.mnuEdit_Paste.Text = "&Paste";
            this.mnuEdit_Paste.Click += new System.EventHandler(this.mnuEdit_Paste_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuView_Compare,
            this.mnuView_sep1,
            this.mnuView_Fullscreen});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 22);
            this.mnuView.Text = "&View";
            // 
            // mnuView_Compare
            // 
            this.mnuView_Compare.CheckOnClick = true;
            this.mnuView_Compare.Image = global::Colors.Properties.Resources.VSplit16;
            this.mnuView_Compare.Name = "mnuView_Compare";
            this.mnuView_Compare.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuView_Compare.Size = new System.Drawing.Size(152, 22);
            this.mnuView_Compare.Text = "&Split";
            this.mnuView_Compare.CheckedChanged += new System.EventHandler(this.mnuView_Compare_CheckedChanged);
            // 
            // mnuView_sep1
            // 
            this.mnuView_sep1.Name = "mnuView_sep1";
            this.mnuView_sep1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuView_Fullscreen
            // 
            this.mnuView_Fullscreen.CheckOnClick = true;
            this.mnuView_Fullscreen.Name = "mnuView_Fullscreen";
            this.mnuView_Fullscreen.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.mnuView_Fullscreen.Size = new System.Drawing.Size(152, 22);
            this.mnuView_Fullscreen.Text = "&Fullscreen";
            this.mnuView_Fullscreen.Click += new System.EventHandler(this.mnuView_Fullscreen_Click);
            // 
            // mnuColor
            // 
            this.mnuColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuColor_Reset,
            this.mnuColor_Random,
            this.mnuColor_Invert});
            this.mnuColor.Name = "mnuColor";
            this.mnuColor.Size = new System.Drawing.Size(48, 22);
            this.mnuColor.Text = "&Color";
            // 
            // mnuColor_Reset
            // 
            this.mnuColor_Reset.Image = global::Colors.Properties.Resources.Reset16;
            this.mnuColor_Reset.Name = "mnuColor_Reset";
            this.mnuColor_Reset.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.mnuColor_Reset.Size = new System.Drawing.Size(194, 22);
            this.mnuColor_Reset.Text = "&Reset Channels";
            this.mnuColor_Reset.Click += new System.EventHandler(this.mnuColor_Reset_Click);
            // 
            // mnuColor_Random
            // 
            this.mnuColor_Random.Image = global::Colors.Properties.Resources.Dice16;
            this.mnuColor_Random.Name = "mnuColor_Random";
            this.mnuColor_Random.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuColor_Random.Size = new System.Drawing.Size(194, 22);
            this.mnuColor_Random.Text = "I\'m Feelin\' &Lucky";
            this.mnuColor_Random.Click += new System.EventHandler(this.mnuColor_Random_Click);
            // 
            // mnuColor_Invert
            // 
            this.mnuColor_Invert.Image = global::Colors.Properties.Resources.Invert16;
            this.mnuColor_Invert.Name = "mnuColor_Invert";
            this.mnuColor_Invert.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.mnuColor_Invert.Size = new System.Drawing.Size(194, 22);
            this.mnuColor_Invert.Text = "&Invert";
            this.mnuColor_Invert.Click += new System.EventHandler(this.mnuColor_Invert_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp_Manual,
            this.mnuHelp_sep1,
            this.mnuHelp_About});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 22);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelp_Manual
            // 
            this.mnuHelp_Manual.Image = global::Colors.Properties.Resources.Help16;
            this.mnuHelp_Manual.Name = "mnuHelp_Manual";
            this.mnuHelp_Manual.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuHelp_Manual.Size = new System.Drawing.Size(146, 22);
            this.mnuHelp_Manual.Text = "View &Help";
            this.mnuHelp_Manual.Click += new System.EventHandler(this.mnuHelp_Manual_Click);
            // 
            // mnuHelp_sep1
            // 
            this.mnuHelp_sep1.Name = "mnuHelp_sep1";
            this.mnuHelp_sep1.Size = new System.Drawing.Size(143, 6);
            // 
            // mnuHelp_About
            // 
            this.mnuHelp_About.Name = "mnuHelp_About";
            this.mnuHelp_About.Size = new System.Drawing.Size(146, 22);
            this.mnuHelp_About.Text = "&About Colors";
            this.mnuHelp_About.Click += new System.EventHandler(this.mnuHelp_About_Click);
            // 
            // tpnlColorTracks
            // 
            this.tpnlColorTracks.AutoSize = true;
            this.tpnlColorTracks.ColumnCount = 3;
            this.tpnlColorTracks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpnlColorTracks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlColorTracks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpnlColorTracks.Controls.Add(this.lblRed, 0, 0);
            this.tpnlColorTracks.Controls.Add(this.lblGreen, 0, 1);
            this.tpnlColorTracks.Controls.Add(this.lblBlue, 0, 2);
            this.tpnlColorTracks.Controls.Add(this.nudRed, 2, 0);
            this.tpnlColorTracks.Controls.Add(this.nudGreen, 2, 1);
            this.tpnlColorTracks.Controls.Add(this.nudBlue, 2, 2);
            this.tpnlColorTracks.Controls.Add(this.tbGreen, 1, 1);
            this.tpnlColorTracks.Controls.Add(this.tbBlue, 1, 2);
            this.tpnlColorTracks.Controls.Add(this.tbRed, 1, 0);
            this.tpnlColorTracks.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpnlColorTracks.Location = new System.Drawing.Point(0, 78);
            this.tpnlColorTracks.Name = "tpnlColorTracks";
            this.tpnlColorTracks.RowCount = 3;
            this.tpnlColorTracks.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnlColorTracks.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnlColorTracks.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnlColorTracks.Size = new System.Drawing.Size(784, 153);
            this.tpnlColorTracks.TabIndex = 2;
            // 
            // lblRed
            // 
            this.lblRed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(21, 19);
            this.lblRed.Margin = new System.Windows.Forms.Padding(10);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(27, 13);
            this.lblRed.TabIndex = 0;
            this.lblRed.Text = "Red";
            // 
            // lblGreen
            // 
            this.lblGreen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(10, 70);
            this.lblGreen.Margin = new System.Windows.Forms.Padding(10);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(38, 13);
            this.lblGreen.TabIndex = 1;
            this.lblGreen.Text = "Green";
            // 
            // lblBlue
            // 
            this.lblBlue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(19, 121);
            this.lblBlue.Margin = new System.Windows.Forms.Padding(10);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(29, 13);
            this.lblBlue.TabIndex = 2;
            this.lblBlue.Text = "Blue";
            // 
            // nudRed
            // 
            this.nudRed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudRed.Location = new System.Drawing.Point(735, 14);
            this.nudRed.Margin = new System.Windows.Forms.Padding(10);
            this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.Name = "nudRed";
            this.nudRed.Size = new System.Drawing.Size(39, 22);
            this.nudRed.TabIndex = 6;
            this.nudRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudRed.ValueChanged += new System.EventHandler(this.ColorNud_ValueChanged);
            this.nudRed.Enter += new System.EventHandler(this.ColorNud_Enter);
            // 
            // nudGreen
            // 
            this.nudGreen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudGreen.Location = new System.Drawing.Point(735, 65);
            this.nudGreen.Margin = new System.Windows.Forms.Padding(10);
            this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.Size = new System.Drawing.Size(39, 22);
            this.nudGreen.TabIndex = 7;
            this.nudGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGreen.ValueChanged += new System.EventHandler(this.ColorNud_ValueChanged);
            this.nudGreen.Enter += new System.EventHandler(this.ColorNud_Enter);
            // 
            // nudBlue
            // 
            this.nudBlue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudBlue.Location = new System.Drawing.Point(735, 116);
            this.nudBlue.Margin = new System.Windows.Forms.Padding(10);
            this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.Size = new System.Drawing.Size(39, 22);
            this.nudBlue.TabIndex = 8;
            this.nudBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBlue.ValueChanged += new System.EventHandler(this.ColorNud_ValueChanged);
            this.nudBlue.Enter += new System.EventHandler(this.ColorNud_Enter);
            // 
            // tbGreen
            // 
            this.tbGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGreen.Location = new System.Drawing.Point(61, 54);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(661, 45);
            this.tbGreen.TabIndex = 4;
            this.tbGreen.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbGreen.ValueChanged += new System.EventHandler(this.ColorBar_ValueChanged);
            this.tbGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorBar_MouseDown);
            // 
            // tbBlue
            // 
            this.tbBlue.BackColor = System.Drawing.SystemColors.Control;
            this.tbBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlue.Location = new System.Drawing.Point(61, 105);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(661, 45);
            this.tbBlue.TabIndex = 5;
            this.tbBlue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbBlue.ValueChanged += new System.EventHandler(this.ColorBar_ValueChanged);
            this.tbBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorBar_MouseDown);
            // 
            // tbRed
            // 
            this.tbRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRed.Location = new System.Drawing.Point(61, 3);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(661, 45);
            this.tbRed.TabIndex = 3;
            this.tbRed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbRed.ValueChanged += new System.EventHandler(this.ColorBar_ValueChanged);
            this.tbRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorBar_MouseDown);
            // 
            // mnuStatusBar
            // 
            this.mnuStatusBar.Location = new System.Drawing.Point(0, 579);
            this.mnuStatusBar.Name = "mnuStatusBar";
            this.mnuStatusBar.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.mnuStatusBar.Size = new System.Drawing.Size(784, 22);
            this.mnuStatusBar.TabIndex = 5;
            this.mnuStatusBar.Text = "Status bar";
            // 
            // spnlSplit
            // 
            this.spnlSplit.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.spnlSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spnlSplit.Location = new System.Drawing.Point(207, 231);
            this.spnlSplit.Name = "spnlSplit";
            // 
            // spnlSplit.Panel1
            // 
            this.spnlSplit.Panel1.Controls.Add(this.pnlSample1);
            // 
            // spnlSplit.Panel2
            // 
            this.spnlSplit.Panel2.Controls.Add(this.pnlSample2);
            this.spnlSplit.Panel2Collapsed = true;
            this.spnlSplit.Size = new System.Drawing.Size(577, 348);
            this.spnlSplit.SplitterDistance = 285;
            this.spnlSplit.SplitterWidth = 3;
            this.spnlSplit.TabIndex = 4;
            // 
            // pnlSample1
            // 
            this.pnlSample1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSample1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSample1.Controls.Add(this.sampleView1);
            this.pnlSample1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlSample1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSample1.Location = new System.Drawing.Point(0, 0);
            this.pnlSample1.Name = "pnlSample1";
            this.pnlSample1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 9);
            this.pnlSample1.Size = new System.Drawing.Size(577, 348);
            this.pnlSample1.TabIndex = 0;
            // 
            // sampleView1
            // 
            this.sampleView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.sampleView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleView1.Location = new System.Drawing.Point(1, 1);
            this.sampleView1.MinimumSize = new System.Drawing.Size(214, 260);
            this.sampleView1.Name = "sampleView1";
            this.sampleView1.SelectedColor = System.Drawing.Color.Empty;
            this.sampleView1.Size = new System.Drawing.Size(573, 336);
            this.sampleView1.TabIndex = 0;
            this.sampleView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sampleView_MouseClick);
            // 
            // pnlSample2
            // 
            this.pnlSample2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlSample2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSample2.Controls.Add(this.sampleView2);
            this.pnlSample2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlSample2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSample2.Location = new System.Drawing.Point(0, 0);
            this.pnlSample2.Name = "pnlSample2";
            this.pnlSample2.Padding = new System.Windows.Forms.Padding(1, 1, 1, 9);
            this.pnlSample2.Size = new System.Drawing.Size(96, 100);
            this.pnlSample2.TabIndex = 1;
            // 
            // sampleView2
            // 
            this.sampleView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.sampleView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleView2.Location = new System.Drawing.Point(1, 1);
            this.sampleView2.MinimumSize = new System.Drawing.Size(214, 260);
            this.sampleView2.Name = "sampleView2";
            this.sampleView2.SelectedColor = System.Drawing.Color.Empty;
            this.sampleView2.Size = new System.Drawing.Size(214, 260);
            this.sampleView2.TabIndex = 0;
            this.sampleView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sampleView_MouseClick);
            // 
            // mnuToolbar
            // 
            this.mnuToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mnuToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.mnuToolbar_sep1,
            this.btnOpen,
            this.btnSave,
            this.mnuToolbar_sep2,
            this.btnCopy,
            this.btnPaste,
            this.mnuToolbar_sep3,
            this.btnCompare,
            this.mnuToolbar_sep4,
            this.btnReset,
            this.btnRandom,
            this.btnInvert,
            this.mnuToolbar_sep5,
            this.btnHelp});
            this.mnuToolbar.Location = new System.Drawing.Point(0, 24);
            this.mnuToolbar.Name = "mnuToolbar";
            this.mnuToolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuToolbar.Size = new System.Drawing.Size(784, 54);
            this.mnuToolbar.TabIndex = 1;
            this.mnuToolbar.Text = "Standard";
            // 
            // btnNew
            // 
            this.btnNew.Image = global::Colors.Properties.Resources.New32;
            this.btnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(36, 51);
            this.btnNew.Text = "&New";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.Click += new System.EventHandler(this.mnuFile_New_Click);
            // 
            // mnuToolbar_sep1
            // 
            this.mnuToolbar_sep1.Name = "mnuToolbar_sep1";
            this.mnuToolbar_sep1.Size = new System.Drawing.Size(6, 54);
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::Colors.Properties.Resources.Open32;
            this.btnOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(40, 51);
            this.btnOpen.Text = "&Open";
            this.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpen.Click += new System.EventHandler(this.mnuFile_Open_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Colors.Properties.Resources.Save32;
            this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 51);
            this.btnSave.Text = "&Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.mnuFile_Save_Click);
            // 
            // mnuToolbar_sep2
            // 
            this.mnuToolbar_sep2.Name = "mnuToolbar_sep2";
            this.mnuToolbar_sep2.Size = new System.Drawing.Size(6, 54);
            // 
            // btnCopy
            // 
            this.btnCopy.Image = global::Colors.Properties.Resources.Copy32;
            this.btnCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(39, 51);
            this.btnCopy.Text = "&Copy";
            this.btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCopy.Click += new System.EventHandler(this.mnuEdit_Copy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Image = global::Colors.Properties.Resources.Paste32;
            this.btnPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(39, 51);
            this.btnPaste.Text = "&Paste";
            this.btnPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPaste.Click += new System.EventHandler(this.mnuEdit_Paste_Click);
            // 
            // mnuToolbar_sep3
            // 
            this.mnuToolbar_sep3.Name = "mnuToolbar_sep3";
            this.mnuToolbar_sep3.Size = new System.Drawing.Size(6, 54);
            // 
            // btnCompare
            // 
            this.btnCompare.CheckOnClick = true;
            this.btnCompare.Image = global::Colors.Properties.Resources.VSplit32;
            this.btnCompare.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCompare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(36, 51);
            this.btnCompare.Text = "Spl&it";
            this.btnCompare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCompare.CheckedChanged += new System.EventHandler(this.btnCompare_CheckedChanged);
            // 
            // mnuToolbar_sep4
            // 
            this.mnuToolbar_sep4.Name = "mnuToolbar_sep4";
            this.mnuToolbar_sep4.Size = new System.Drawing.Size(6, 54);
            // 
            // btnReset
            // 
            this.btnReset.Image = global::Colors.Properties.Resources.Reset32;
            this.btnReset.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(39, 51);
            this.btnReset.Text = "&Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReset.Click += new System.EventHandler(this.mnuColor_Reset_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Image = global::Colors.Properties.Resources.Dice32;
            this.btnRandom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRandom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(42, 51);
            this.btnRandom.Text = "&Lucky";
            this.btnRandom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRandom.Click += new System.EventHandler(this.mnuColor_Random_Click);
            // 
            // btnInvert
            // 
            this.btnInvert.Image = global::Colors.Properties.Resources.Invert32;
            this.btnInvert.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInvert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(41, 51);
            this.btnInvert.Text = "In&vert";
            this.btnInvert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInvert.Click += new System.EventHandler(this.mnuColor_Invert_Click);
            // 
            // mnuToolbar_sep5
            // 
            this.mnuToolbar_sep5.Name = "mnuToolbar_sep5";
            this.mnuToolbar_sep5.Size = new System.Drawing.Size(6, 54);
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::Colors.Properties.Resources.Help32;
            this.btnHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(36, 51);
            this.btnHelp.Text = "&Help";
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHelp.Click += new System.EventHandler(this.mnuHelp_Manual_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tmrParty
            // 
            this.tmrParty.Interval = 1;
            this.tmrParty.Tick += new System.EventHandler(this.tmrParty_Tick);
            // 
            // colorPalette
            // 
            this.colorPalette.Dock = System.Windows.Forms.DockStyle.Left;
            this.colorPalette.Location = new System.Drawing.Point(0, 231);
            this.colorPalette.Name = "colorPalette";
            this.colorPalette.SelectedColor = System.Drawing.Color.Empty;
            this.colorPalette.Size = new System.Drawing.Size(207, 348);
            this.colorPalette.TabIndex = 3;
            this.colorPalette.SelectedColorChanged += new Colors.ColorPaletteControl.SelectedColorChangedEventHandler(this.colorPalette_SelectedColorChanged);
            // 
            // ColorPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 601);
            this.Controls.Add(this.spnlSplit);
            this.Controls.Add(this.colorPalette);
            this.Controls.Add(this.mnuStatusBar);
            this.Controls.Add(this.tpnlColorTracks);
            this.Controls.Add(this.mnuToolbar);
            this.Controls.Add(this.mnuMenubar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuMenubar;
            this.MinimumSize = new System.Drawing.Size(645, 482);
            this.Name = "ColorPickerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colors";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ColorPickerForm_KeyDown);
            this.mnuMenubar.ResumeLayout(false);
            this.mnuMenubar.PerformLayout();
            this.tpnlColorTracks.ResumeLayout(false);
            this.tpnlColorTracks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            this.spnlSplit.Panel1.ResumeLayout(false);
            this.spnlSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spnlSplit)).EndInit();
            this.spnlSplit.ResumeLayout(false);
            this.pnlSample1.ResumeLayout(false);
            this.pnlSample2.ResumeLayout(false);
            this.mnuToolbar.ResumeLayout(false);
            this.mnuToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenubar;
        private System.Windows.Forms.TableLayoutPanel tpnlColorTracks;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.NumericUpDown nudRed;
        private System.Windows.Forms.NumericUpDown nudGreen;
        private System.Windows.Forms.NumericUpDown nudBlue;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_New;
        private System.Windows.Forms.ToolStripMenuItem mnuColor;
        private System.Windows.Forms.ToolStripMenuItem mnuColor_Reset;
        private System.Windows.Forms.ToolStripMenuItem mnuColor_Random;
        private System.Windows.Forms.ToolStripMenuItem mnuColor_Invert;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.StatusStrip mnuStatusBar;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp_Manual;
        private System.Windows.Forms.ToolStripSeparator mnuHelp_sep1;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp_About;
        private System.Windows.Forms.ToolStripSeparator mnuFile_sep1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Save;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Exit;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Open;
        private System.Windows.Forms.ToolStripSeparator mnuFile_sep2;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuView_Compare;
        private ColorPaletteControl colorPalette;
        private System.Windows.Forms.SplitContainer spnlSplit;
        private System.Windows.Forms.Panel pnlSample1;
        private SampleView sampleView1;
        private System.Windows.Forms.Panel pnlSample2;
        private SampleView sampleView2;
        private System.Windows.Forms.ToolStrip mnuToolbar;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripSeparator mnuToolbar_sep1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator mnuToolbar_sep2;
        private System.Windows.Forms.ToolStripButton btnCompare;
        private System.Windows.Forms.ToolStripSeparator mnuToolbar_sep3;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.ToolStripSeparator mnuToolbar_sep4;
        private System.Windows.Forms.ToolStripButton btnReset;
        private System.Windows.Forms.ToolStripButton btnRandom;
        private System.Windows.Forms.ToolStripButton btnInvert;
        private System.Windows.Forms.ToolStripSeparator mnuToolbar_sep5;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit_Copy;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit_Paste;
        private System.Windows.Forms.ToolStripButton btnPaste;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer tmrParty;
        private System.Windows.Forms.ToolStripSeparator mnuView_sep1;
        private System.Windows.Forms.ToolStripMenuItem mnuView_Fullscreen;
    }
}
