namespace Audio_Player
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.bnfImgBtnMaxWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnfImgBtnMinWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnfImgBtnCloseWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton7 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnfCstmLblName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelVisualization = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.bnfCstmLblPlayingTrack = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuProgressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.footer = new System.Windows.Forms.Panel();
            this.bnfImgBtnAudiobookMode = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSliderVolume = new Bunifu.Framework.UI.BunifuSlider();
            this.bnfImgBtnPlaylist = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnfCstmLblTrackDuration = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bnfCstmLblTrackCurPosition = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bnfImgBtnVolume = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnfImgBtnRepeat = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnfImgBtnPause = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnfImgBtnStop = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnfImgBtnNextTrack = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnfImgBtnPreviousTrack = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnfImgBtnPlay = new Bunifu.Framework.UI.BunifuImageButton();
            this.listBoxPlaylist = new System.Windows.Forms.ListBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnMaxWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnMinWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnCloseWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).BeginInit();
            this.panelVisualization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnAudiobookMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnNextTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnPreviousTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnPlay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.header.Controls.Add(this.bnfImgBtnMaxWindow);
            this.header.Controls.Add(this.bnfImgBtnMinWindow);
            this.header.Controls.Add(this.bnfImgBtnCloseWindow);
            this.header.Controls.Add(this.bunifuImageButton7);
            this.header.Controls.Add(this.bnfCstmLblName);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(910, 39);
            this.header.TabIndex = 0;
            // 
            // bnfImgBtnMaxWindow
            // 
            this.bnfImgBtnMaxWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnfImgBtnMaxWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bnfImgBtnMaxWindow.Image = ((System.Drawing.Image)(resources.GetObject("bnfImgBtnMaxWindow.Image")));
            this.bnfImgBtnMaxWindow.ImageActive = null;
            this.bnfImgBtnMaxWindow.Location = new System.Drawing.Point(848, 4);
            this.bnfImgBtnMaxWindow.Name = "bnfImgBtnMaxWindow";
            this.bnfImgBtnMaxWindow.Size = new System.Drawing.Size(22, 28);
            this.bnfImgBtnMaxWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnfImgBtnMaxWindow.TabIndex = 14;
            this.bnfImgBtnMaxWindow.TabStop = false;
            this.bnfImgBtnMaxWindow.Zoom = 10;
            this.bnfImgBtnMaxWindow.Click += new System.EventHandler(this.bnfImgBtnMaxWindow_Click);
            // 
            // bnfImgBtnMinWindow
            // 
            this.bnfImgBtnMinWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnfImgBtnMinWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bnfImgBtnMinWindow.Image = ((System.Drawing.Image)(resources.GetObject("bnfImgBtnMinWindow.Image")));
            this.bnfImgBtnMinWindow.ImageActive = null;
            this.bnfImgBtnMinWindow.Location = new System.Drawing.Point(820, 4);
            this.bnfImgBtnMinWindow.Name = "bnfImgBtnMinWindow";
            this.bnfImgBtnMinWindow.Size = new System.Drawing.Size(22, 28);
            this.bnfImgBtnMinWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnfImgBtnMinWindow.TabIndex = 13;
            this.bnfImgBtnMinWindow.TabStop = false;
            this.bnfImgBtnMinWindow.Zoom = 10;
            this.bnfImgBtnMinWindow.Click += new System.EventHandler(this.bnfImgBtnMinWindow_Click);
            // 
            // bnfImgBtnCloseWindow
            // 
            this.bnfImgBtnCloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnfImgBtnCloseWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bnfImgBtnCloseWindow.Image = ((System.Drawing.Image)(resources.GetObject("bnfImgBtnCloseWindow.Image")));
            this.bnfImgBtnCloseWindow.ImageActive = null;
            this.bnfImgBtnCloseWindow.Location = new System.Drawing.Point(876, 5);
            this.bnfImgBtnCloseWindow.Name = "bnfImgBtnCloseWindow";
            this.bnfImgBtnCloseWindow.Size = new System.Drawing.Size(22, 28);
            this.bnfImgBtnCloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnfImgBtnCloseWindow.TabIndex = 12;
            this.bnfImgBtnCloseWindow.TabStop = false;
            this.bnfImgBtnCloseWindow.Zoom = 10;
            this.bnfImgBtnCloseWindow.Click += new System.EventHandler(this.bnfImgBtnCloseWindow_Click);
            // 
            // bunifuImageButton7
            // 
            this.bunifuImageButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bunifuImageButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton7.Image")));
            this.bunifuImageButton7.ImageActive = null;
            this.bunifuImageButton7.Location = new System.Drawing.Point(3, 4);
            this.bunifuImageButton7.Name = "bunifuImageButton7";
            this.bunifuImageButton7.Size = new System.Drawing.Size(32, 29);
            this.bunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton7.TabIndex = 6;
            this.bunifuImageButton7.TabStop = false;
            this.bunifuImageButton7.Zoom = 10;
            // 
            // bnfCstmLblName
            // 
            this.bnfCstmLblName.AutoSize = true;
            this.bnfCstmLblName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnfCstmLblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnfCstmLblName.Location = new System.Drawing.Point(41, 9);
            this.bnfCstmLblName.Name = "bnfCstmLblName";
            this.bnfCstmLblName.Size = new System.Drawing.Size(101, 20);
            this.bnfCstmLblName.TabIndex = 0;
            this.bnfCstmLblName.Text = "Audio Player";
            // 
            // panelVisualization
            // 
            this.panelVisualization.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVisualization.BackColor = System.Drawing.Color.Black;
            this.panelVisualization.Controls.Add(this.axWindowsMediaPlayer);
            this.panelVisualization.Controls.Add(this.bnfCstmLblPlayingTrack);
            this.panelVisualization.Controls.Add(this.bunifuProgressBar);
            this.panelVisualization.Location = new System.Drawing.Point(0, 39);
            this.panelVisualization.Name = "panelVisualization";
            this.panelVisualization.Size = new System.Drawing.Size(695, 399);
            this.panelVisualization.TabIndex = 2;
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(695, 369);
            this.axWindowsMediaPlayer.TabIndex = 16;
            // 
            // bnfCstmLblPlayingTrack
            // 
            this.bnfCstmLblPlayingTrack.AutoSize = true;
            this.bnfCstmLblPlayingTrack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnfCstmLblPlayingTrack.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnfCstmLblPlayingTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnfCstmLblPlayingTrack.Location = new System.Drawing.Point(0, 369);
            this.bnfCstmLblPlayingTrack.Name = "bnfCstmLblPlayingTrack";
            this.bnfCstmLblPlayingTrack.Size = new System.Drawing.Size(87, 20);
            this.bnfCstmLblPlayingTrack.TabIndex = 15;
            this.bnfCstmLblPlayingTrack.Text = "Загрузка...";
            // 
            // bunifuProgressBar
            // 
            this.bunifuProgressBar.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar.BorderRadius = 5;
            this.bunifuProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuProgressBar.Location = new System.Drawing.Point(0, 389);
            this.bunifuProgressBar.MaximumValue = 100;
            this.bunifuProgressBar.Name = "bunifuProgressBar";
            this.bunifuProgressBar.ProgressColor = System.Drawing.Color.MediumSpringGreen;
            this.bunifuProgressBar.Size = new System.Drawing.Size(695, 10);
            this.bunifuProgressBar.TabIndex = 1;
            this.bunifuProgressBar.Value = 0;
            this.bunifuProgressBar.progressChanged += new System.EventHandler(this.bunifuProgressBar_progressChanged);
            // 
            // footer
            // 
            this.footer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.footer.Controls.Add(this.bnfImgBtnAudiobookMode);
            this.footer.Controls.Add(this.bunifuSliderVolume);
            this.footer.Controls.Add(this.bnfImgBtnPlaylist);
            this.footer.Controls.Add(this.bnfCstmLblTrackDuration);
            this.footer.Controls.Add(this.bnfCstmLblTrackCurPosition);
            this.footer.Controls.Add(this.bnfImgBtnVolume);
            this.footer.Controls.Add(this.bnfImgBtnRepeat);
            this.footer.Controls.Add(this.bnfImgBtnPause);
            this.footer.Controls.Add(this.bnfImgBtnStop);
            this.footer.Controls.Add(this.bnfImgBtnNextTrack);
            this.footer.Controls.Add(this.bnfImgBtnPreviousTrack);
            this.footer.Controls.Add(this.bnfImgBtnPlay);
            this.footer.Location = new System.Drawing.Point(0, 434);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(695, 110);
            this.footer.TabIndex = 0;
            // 
            // bnfImgBtnAudiobookMode
            // 
            this.bnfImgBtnAudiobookMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bnfImgBtnAudiobookMode.Image = global::Audio_Player.Properties.Resources.Book_96px;
            this.bnfImgBtnAudiobookMode.ImageActive = null;
            this.bnfImgBtnAudiobookMode.Location = new System.Drawing.Point(419, 52);
            this.bnfImgBtnAudiobookMode.Name = "bnfImgBtnAudiobookMode";
            this.bnfImgBtnAudiobookMode.Size = new System.Drawing.Size(31, 31);
            this.bnfImgBtnAudiobookMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnfImgBtnAudiobookMode.TabIndex = 18;
            this.bnfImgBtnAudiobookMode.TabStop = false;
            this.bnfImgBtnAudiobookMode.Zoom = 10;
            this.bnfImgBtnAudiobookMode.Click += new System.EventHandler(this.bnfImgBtnAudiobookMode_Click);
            // 
            // bunifuSliderVolume
            // 
            this.bunifuSliderVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSliderVolume.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSliderVolume.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSliderVolume.BorderRadius = 0;
            this.bunifuSliderVolume.IndicatorColor = System.Drawing.Color.MediumSpringGreen;
            this.bunifuSliderVolume.Location = new System.Drawing.Point(513, 53);
            this.bunifuSliderVolume.MaximumValue = 100;
            this.bunifuSliderVolume.Name = "bunifuSliderVolume";
            this.bunifuSliderVolume.Size = new System.Drawing.Size(171, 30);
            this.bunifuSliderVolume.TabIndex = 17;
            this.bunifuSliderVolume.Value = 35;
            this.bunifuSliderVolume.ValueChanged += new System.EventHandler(this.bunifuSliderVolume_ValueChanged);
            // 
            // bnfImgBtnPlaylist
            // 
            this.bnfImgBtnPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bnfImgBtnPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("bnfImgBtnPlaylist.Image")));
            this.bnfImgBtnPlaylist.ImageActive = null;
            this.bnfImgBtnPlaylist.Location = new System.Drawing.Point(382, 53);
            this.bnfImgBtnPlaylist.Name = "bnfImgBtnPlaylist";
            this.bnfImgBtnPlaylist.Size = new System.Drawing.Size(31, 31);
            this.bnfImgBtnPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnfImgBtnPlaylist.TabIndex = 12;
            this.bnfImgBtnPlaylist.TabStop = false;
            this.bnfImgBtnPlaylist.Zoom = 10;
            this.bnfImgBtnPlaylist.Click += new System.EventHandler(this.bnfImgBtnPlaylist_Click);
            // 
            // bnfCstmLblTrackDuration
            // 
            this.bnfCstmLblTrackDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnfCstmLblTrackDuration.AutoSize = true;
            this.bnfCstmLblTrackDuration.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnfCstmLblTrackDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnfCstmLblTrackDuration.Location = new System.Drawing.Point(640, 7);
            this.bnfCstmLblTrackDuration.Name = "bnfCstmLblTrackDuration";
            this.bnfCstmLblTrackDuration.Size = new System.Drawing.Size(49, 20);
            this.bnfCstmLblTrackDuration.TabIndex = 14;
            this.bnfCstmLblTrackDuration.Text = "0:0:00";
            // 
            // bnfCstmLblTrackCurPosition
            // 
            this.bnfCstmLblTrackCurPosition.AutoSize = true;
            this.bnfCstmLblTrackCurPosition.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnfCstmLblTrackCurPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnfCstmLblTrackCurPosition.Location = new System.Drawing.Point(3, 7);
            this.bnfCstmLblTrackCurPosition.Name = "bnfCstmLblTrackCurPosition";
            this.bnfCstmLblTrackCurPosition.Size = new System.Drawing.Size(49, 20);
            this.bnfCstmLblTrackCurPosition.TabIndex = 13;
            this.bnfCstmLblTrackCurPosition.Text = "0:0:00";
            // 
            // bnfImgBtnVolume
            // 
            this.bnfImgBtnVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnfImgBtnVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bnfImgBtnVolume.Image = global::Audio_Player.Properties.Resources.Medium_Volume_96px;
            this.bnfImgBtnVolume.ImageActive = null;
            this.bnfImgBtnVolume.Location = new System.Drawing.Point(478, 54);
            this.bnfImgBtnVolume.Name = "bnfImgBtnVolume";
            this.bnfImgBtnVolume.Size = new System.Drawing.Size(29, 25);
            this.bnfImgBtnVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnfImgBtnVolume.TabIndex = 12;
            this.bnfImgBtnVolume.TabStop = false;
            this.bnfImgBtnVolume.Zoom = 10;
            this.bnfImgBtnVolume.Click += new System.EventHandler(this.bnfImgBtnVolume_Click);
            // 
            // bnfImgBtnRepeat
            // 
            this.bnfImgBtnRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bnfImgBtnRepeat.Image = global::Audio_Player.Properties.Resources.Repeat_white__96px;
            this.bnfImgBtnRepeat.ImageActive = null;
            this.bnfImgBtnRepeat.Location = new System.Drawing.Point(345, 53);
            this.bnfImgBtnRepeat.Name = "bnfImgBtnRepeat";
            this.bnfImgBtnRepeat.Size = new System.Drawing.Size(31, 31);
            this.bnfImgBtnRepeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnfImgBtnRepeat.TabIndex = 11;
            this.bnfImgBtnRepeat.TabStop = false;
            this.bnfImgBtnRepeat.Zoom = 10;
            this.bnfImgBtnRepeat.Click += new System.EventHandler(this.bnfImgBtnRepeat_Click);
            // 
            // bnfImgBtnPause
            // 
            this.bnfImgBtnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bnfImgBtnPause.Image = ((System.Drawing.Image)(resources.GetObject("bnfImgBtnPause.Image")));
            this.bnfImgBtnPause.ImageActive = null;
            this.bnfImgBtnPause.Location = new System.Drawing.Point(189, 38);
            this.bnfImgBtnPause.Name = "bnfImgBtnPause";
            this.bnfImgBtnPause.Size = new System.Drawing.Size(51, 51);
            this.bnfImgBtnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnfImgBtnPause.TabIndex = 10;
            this.bnfImgBtnPause.TabStop = false;
            this.bnfImgBtnPause.Zoom = 10;
            this.bnfImgBtnPause.Click += new System.EventHandler(this.bnfImgBtnPause_Click);
            // 
            // bnfImgBtnStop
            // 
            this.bnfImgBtnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bnfImgBtnStop.Image = ((System.Drawing.Image)(resources.GetObject("bnfImgBtnStop.Image")));
            this.bnfImgBtnStop.ImageActive = null;
            this.bnfImgBtnStop.Location = new System.Drawing.Point(75, 38);
            this.bnfImgBtnStop.Name = "bnfImgBtnStop";
            this.bnfImgBtnStop.Size = new System.Drawing.Size(51, 51);
            this.bnfImgBtnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnfImgBtnStop.TabIndex = 7;
            this.bnfImgBtnStop.TabStop = false;
            this.bnfImgBtnStop.Zoom = 10;
            this.bnfImgBtnStop.Click += new System.EventHandler(this.bnfImgBtnStop_Click);
            // 
            // bnfImgBtnNextTrack
            // 
            this.bnfImgBtnNextTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bnfImgBtnNextTrack.Image = ((System.Drawing.Image)(resources.GetObject("bnfImgBtnNextTrack.Image")));
            this.bnfImgBtnNextTrack.ImageActive = null;
            this.bnfImgBtnNextTrack.Location = new System.Drawing.Point(246, 38);
            this.bnfImgBtnNextTrack.Name = "bnfImgBtnNextTrack";
            this.bnfImgBtnNextTrack.Size = new System.Drawing.Size(51, 51);
            this.bnfImgBtnNextTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnfImgBtnNextTrack.TabIndex = 9;
            this.bnfImgBtnNextTrack.TabStop = false;
            this.bnfImgBtnNextTrack.Zoom = 10;
            this.bnfImgBtnNextTrack.Click += new System.EventHandler(this.bnfImgBtnNextTrack_Click);
            // 
            // bnfImgBtnPreviousTrack
            // 
            this.bnfImgBtnPreviousTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bnfImgBtnPreviousTrack.Image = ((System.Drawing.Image)(resources.GetObject("bnfImgBtnPreviousTrack.Image")));
            this.bnfImgBtnPreviousTrack.ImageActive = null;
            this.bnfImgBtnPreviousTrack.Location = new System.Drawing.Point(18, 38);
            this.bnfImgBtnPreviousTrack.Name = "bnfImgBtnPreviousTrack";
            this.bnfImgBtnPreviousTrack.Size = new System.Drawing.Size(51, 51);
            this.bnfImgBtnPreviousTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnfImgBtnPreviousTrack.TabIndex = 8;
            this.bnfImgBtnPreviousTrack.TabStop = false;
            this.bnfImgBtnPreviousTrack.Zoom = 10;
            this.bnfImgBtnPreviousTrack.Click += new System.EventHandler(this.bnfImgBtnPreviousTrack_Click);
            // 
            // bnfImgBtnPlay
            // 
            this.bnfImgBtnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bnfImgBtnPlay.Image = ((System.Drawing.Image)(resources.GetObject("bnfImgBtnPlay.Image")));
            this.bnfImgBtnPlay.ImageActive = null;
            this.bnfImgBtnPlay.Location = new System.Drawing.Point(132, 38);
            this.bnfImgBtnPlay.Name = "bnfImgBtnPlay";
            this.bnfImgBtnPlay.Size = new System.Drawing.Size(51, 51);
            this.bnfImgBtnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnfImgBtnPlay.TabIndex = 6;
            this.bnfImgBtnPlay.TabStop = false;
            this.bnfImgBtnPlay.Zoom = 10;
            this.bnfImgBtnPlay.Click += new System.EventHandler(this.bnfImgBtnPlay_Click);
            // 
            // listBoxPlaylist
            // 
            this.listBoxPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.listBoxPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxPlaylist.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.listBoxPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxPlaylist.FormattingEnabled = true;
            this.listBoxPlaylist.HorizontalScrollbar = true;
            this.listBoxPlaylist.ItemHeight = 20;
            this.listBoxPlaylist.Location = new System.Drawing.Point(0, 25);
            this.listBoxPlaylist.Name = "listBoxPlaylist";
            this.listBoxPlaylist.Size = new System.Drawing.Size(215, 480);
            this.listBoxPlaylist.TabIndex = 2;
            this.listBoxPlaylist.SelectedIndexChanged += new System.EventHandler(this.listBoxPlaylist_SelectedIndexChanged);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.footer;
            this.bunifuDragControl2.Vertical = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(75, 3);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(79, 20);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Плейлист";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.listBoxPlaylist);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(695, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 505);
            this.panel1.TabIndex = 16;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(910, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelVisualization);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnMaxWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnMinWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnCloseWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).EndInit();
            this.panelVisualization.ResumeLayout(false);
            this.panelVisualization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnAudiobookMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnNextTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnPreviousTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgBtnPlay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelVisualization;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel footer;
        private Bunifu.Framework.UI.BunifuCustomLabel bnfCstmLblName;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton7;
        private Bunifu.Framework.UI.BunifuImageButton bnfImgBtnPause;
        private Bunifu.Framework.UI.BunifuImageButton bnfImgBtnStop;
        private Bunifu.Framework.UI.BunifuImageButton bnfImgBtnNextTrack;
        private Bunifu.Framework.UI.BunifuImageButton bnfImgBtnPreviousTrack;
        private Bunifu.Framework.UI.BunifuImageButton bnfImgBtnPlay;
        private Bunifu.Framework.UI.BunifuImageButton bnfImgBtnVolume;
        private Bunifu.Framework.UI.BunifuImageButton bnfImgBtnRepeat;
        private Bunifu.Framework.UI.BunifuImageButton bnfImgBtnMaxWindow;
        private Bunifu.Framework.UI.BunifuImageButton bnfImgBtnMinWindow;
        private Bunifu.Framework.UI.BunifuImageButton bnfImgBtnCloseWindow;
        private Bunifu.Framework.UI.BunifuCustomLabel bnfCstmLblTrackDuration;
        private Bunifu.Framework.UI.BunifuCustomLabel bnfCstmLblTrackCurPosition;
        private Bunifu.Framework.UI.BunifuCustomLabel bnfCstmLblPlayingTrack;
        private Bunifu.Framework.UI.BunifuImageButton bnfImgBtnPlaylist;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer timer;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ListBox listBoxPlaylist;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private Bunifu.Framework.UI.BunifuSlider bunifuSliderVolume;
        private Bunifu.Framework.UI.BunifuImageButton bnfImgBtnAudiobookMode;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar;
    }
}

