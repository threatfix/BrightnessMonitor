namespace WindowsFormsApplication2
{
    partial class BrightnessModifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrightnessModifier));
            this.brightnessTrack = new System.Windows.Forms.TrackBar();
            this.threatBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.systemTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.Label();
            this.tFixLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.incBtn = new System.Windows.Forms.Button();
            this.decBtn = new System.Windows.Forms.Button();
            this.masterLbl = new System.Windows.Forms.Label();
            this.schedulerLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dayCheckB = new System.Windows.Forms.CheckBox();
            this.dayGroupBox = new System.Windows.Forms.GroupBox();
            this.dayGradual = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtPickDay = new System.Windows.Forms.DateTimePicker();
            this.decDay = new System.Windows.Forms.Button();
            this.incDay = new System.Windows.Forms.Button();
            this.dayLbl = new System.Windows.Forms.Label();
            this.dayTB = new System.Windows.Forms.TrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nightCheckB = new System.Windows.Forms.CheckBox();
            this.nightGroupBox = new System.Windows.Forms.GroupBox();
            this.nightGradual = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtPickNight = new System.Windows.Forms.DateTimePicker();
            this.decNight = new System.Windows.Forms.Button();
            this.incNight = new System.Windows.Forms.Button();
            this.nightLbl = new System.Windows.Forms.Label();
            this.nightTB = new System.Windows.Forms.TrackBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.systemTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.startupCB = new System.Windows.Forms.CheckBox();
            this.trayBox = new System.Windows.Forms.CheckBox();
            this.disableBtn = new System.Windows.Forms.Button();
            this.masterGroupBox = new System.Windows.Forms.GroupBox();
            this.masterCollapseBtn = new System.Windows.Forms.Button();
            this.schedulerGroupbBox = new System.Windows.Forms.GroupBox();
            this.scheduleCollapseBtn = new System.Windows.Forms.Button();
            this.otherGroupBox = new System.Windows.Forms.GroupBox();
            this.otherLbl = new System.Windows.Forms.Label();
            this.otherCollapseBtn = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.currentBrightnessLbl = new System.Windows.Forms.Label();
            this.dayBackLbl = new System.Windows.Forms.Label();
            this.dayBackTime = new System.Windows.Forms.Label();
            this.dayBackBrightness = new System.Windows.Forms.Label();
            this.dayBackGradual = new System.Windows.Forms.Label();
            this.nightBackGradual = new System.Windows.Forms.Label();
            this.nightBackBrightness = new System.Windows.Forms.Label();
            this.nightBackTime = new System.Windows.Forms.Label();
            this.nightBackLbl = new System.Windows.Forms.Label();
            this.startBackLbl = new System.Windows.Forms.Label();
            this.trayBackLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threatBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.nightGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nightTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.masterGroupBox.SuspendLayout();
            this.schedulerGroupbBox.SuspendLayout();
            this.otherGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // brightnessTrack
            // 
            this.brightnessTrack.BackColor = System.Drawing.SystemColors.Control;
            this.brightnessTrack.LargeChange = 1;
            this.brightnessTrack.Location = new System.Drawing.Point(41, 56);
            this.brightnessTrack.Maximum = 100;
            this.brightnessTrack.Minimum = 1;
            this.brightnessTrack.Name = "brightnessTrack";
            this.brightnessTrack.Size = new System.Drawing.Size(250, 45);
            this.brightnessTrack.TabIndex = 5;
            this.brightnessTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.brightnessTrack.Value = 50;
            this.brightnessTrack.ValueChanged += new System.EventHandler(this.brightnessTrack_ValueChanged);
            // 
            // threatBox
            // 
            this.threatBox.BackColor = System.Drawing.Color.Gainsboro;
            this.threatBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.threatBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.threatBox.Image = ((System.Drawing.Image)(resources.GetObject("threatBox.Image")));
            this.threatBox.Location = new System.Drawing.Point(-10, -1);
            this.threatBox.Margin = new System.Windows.Forms.Padding(2);
            this.threatBox.Name = "threatBox";
            this.threatBox.Size = new System.Drawing.Size(442, 77);
            this.threatBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.threatBox.TabIndex = 13;
            this.threatBox.TabStop = false;
            this.threatBox.Click += new System.EventHandler(this.threatBox_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.systemTime);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.statusBar);
            this.panel2.Controls.Add(this.tFixLink);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-19, 633);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 27);
            this.panel2.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F);
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(361, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 15);
            this.label14.TabIndex = 74;
            this.label14.Text = "|";
            // 
            // systemTime
            // 
            this.systemTime.AutoSize = true;
            this.systemTime.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F);
            this.systemTime.ForeColor = System.Drawing.Color.Gray;
            this.systemTime.Location = new System.Drawing.Point(371, 4);
            this.systemTime.Name = "systemTime";
            this.systemTime.Size = new System.Drawing.Size(68, 15);
            this.systemTime.TabIndex = 73;
            this.systemTime.Text = "12:00:00 AM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(18, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Brightness Monitor";
            // 
            // statusBar
            // 
            this.statusBar.AutoSize = true;
            this.statusBar.ForeColor = System.Drawing.Color.Gray;
            this.statusBar.Location = new System.Drawing.Point(18, 3);
            this.statusBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(0, 13);
            this.statusBar.TabIndex = 19;
            // 
            // tFixLink
            // 
            this.tFixLink.AutoSize = true;
            this.tFixLink.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tFixLink.Location = new System.Drawing.Point(291, 4);
            this.tFixLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tFixLink.Name = "tFixLink";
            this.tFixLink.Size = new System.Drawing.Size(75, 15);
            this.tFixLink.TabIndex = 17;
            this.tFixLink.TabStop = true;
            this.tFixLink.Text = "ThreatFix.com";
            this.tFixLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tFixLink_LinkClicked_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(249, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Visit us:";
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brightnessLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.brightnessLabel.Location = new System.Drawing.Point(350, 59);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(21, 15);
            this.brightnessLabel.TabIndex = 32;
            this.brightnessLabel.Text = "50";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 35);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // incBtn
            // 
            this.incBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incBtn.Location = new System.Drawing.Point(319, 54);
            this.incBtn.Name = "incBtn";
            this.incBtn.Size = new System.Drawing.Size(26, 23);
            this.incBtn.TabIndex = 34;
            this.incBtn.Text = "+";
            this.incBtn.UseVisualStyleBackColor = true;
            this.incBtn.Click += new System.EventHandler(this.incBtn_Click);
            // 
            // decBtn
            // 
            this.decBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decBtn.Location = new System.Drawing.Point(289, 54);
            this.decBtn.Name = "decBtn";
            this.decBtn.Size = new System.Drawing.Size(26, 23);
            this.decBtn.TabIndex = 35;
            this.decBtn.Text = "-";
            this.decBtn.UseVisualStyleBackColor = true;
            this.decBtn.Click += new System.EventHandler(this.decBtn_Click);
            // 
            // masterLbl
            // 
            this.masterLbl.AutoSize = true;
            this.masterLbl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.masterLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.masterLbl.Location = new System.Drawing.Point(6, 11);
            this.masterLbl.Name = "masterLbl";
            this.masterLbl.Size = new System.Drawing.Size(46, 15);
            this.masterLbl.TabIndex = 36;
            this.masterLbl.Text = "Master";
            // 
            // schedulerLbl
            // 
            this.schedulerLbl.AutoSize = true;
            this.schedulerLbl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.schedulerLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.schedulerLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulerLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.schedulerLbl.Location = new System.Drawing.Point(6, 11);
            this.schedulerLbl.Name = "schedulerLbl";
            this.schedulerLbl.Size = new System.Drawing.Size(63, 15);
            this.schedulerLbl.TabIndex = 37;
            this.schedulerLbl.Text = "Scheduler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Startup";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(6, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Windows Tray";
            // 
            // dayCheckB
            // 
            this.dayCheckB.AutoSize = true;
            this.dayCheckB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dayCheckB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dayCheckB.Location = new System.Drawing.Point(15, 35);
            this.dayCheckB.Name = "dayCheckB";
            this.dayCheckB.Size = new System.Drawing.Size(52, 19);
            this.dayCheckB.TabIndex = 44;
            this.dayCheckB.Text = "Days";
            this.dayCheckB.UseVisualStyleBackColor = true;
            this.dayCheckB.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // dayGroupBox
            // 
            this.dayGroupBox.Controls.Add(this.dayGradual);
            this.dayGroupBox.Controls.Add(this.label10);
            this.dayGroupBox.Controls.Add(this.label9);
            this.dayGroupBox.Controls.Add(this.dtPickDay);
            this.dayGroupBox.Controls.Add(this.decDay);
            this.dayGroupBox.Controls.Add(this.incDay);
            this.dayGroupBox.Controls.Add(this.dayLbl);
            this.dayGroupBox.Controls.Add(this.dayTB);
            this.dayGroupBox.Controls.Add(this.pictureBox2);
            this.dayGroupBox.Enabled = false;
            this.dayGroupBox.Location = new System.Drawing.Point(15, 60);
            this.dayGroupBox.Name = "dayGroupBox";
            this.dayGroupBox.Size = new System.Drawing.Size(362, 108);
            this.dayGroupBox.TabIndex = 70;
            this.dayGroupBox.TabStop = false;
            // 
            // dayGradual
            // 
            this.dayGradual.AutoSize = true;
            this.dayGradual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dayGradual.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dayGradual.Location = new System.Drawing.Point(110, 36);
            this.dayGradual.Name = "dayGradual";
            this.dayGradual.Size = new System.Drawing.Size(15, 14);
            this.dayGradual.TabIndex = 78;
            this.dayGradual.UseVisualStyleBackColor = true;
            this.dayGradual.CheckedChanged += new System.EventHandler(this.dayGradual_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(4, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 15);
            this.label10.TabIndex = 77;
            this.label10.Text = "Gradual Change?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(4, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 76;
            this.label9.Text = "Time of Effect";
            // 
            // dtPickDay
            // 
            this.dtPickDay.CustomFormat = "hh:mm:ss tt";
            this.dtPickDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickDay.Location = new System.Drawing.Point(110, 10);
            this.dtPickDay.Name = "dtPickDay";
            this.dtPickDay.ShowUpDown = true;
            this.dtPickDay.Size = new System.Drawing.Size(96, 20);
            this.dtPickDay.TabIndex = 70;
            this.dtPickDay.Value = new System.DateTime(2015, 12, 30, 0, 0, 0, 0);
            this.dtPickDay.ValueChanged += new System.EventHandler(this.dtPickDay_ValueChanged);
            // 
            // decDay
            // 
            this.decDay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decDay.Location = new System.Drawing.Point(268, 59);
            this.decDay.Name = "decDay";
            this.decDay.Size = new System.Drawing.Size(26, 23);
            this.decDay.TabIndex = 75;
            this.decDay.Text = "-";
            this.decDay.UseVisualStyleBackColor = true;
            this.decDay.Click += new System.EventHandler(this.decDay_Click);
            // 
            // incDay
            // 
            this.incDay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incDay.Location = new System.Drawing.Point(298, 59);
            this.incDay.Name = "incDay";
            this.incDay.Size = new System.Drawing.Size(26, 23);
            this.incDay.TabIndex = 74;
            this.incDay.Text = "+";
            this.incDay.UseVisualStyleBackColor = true;
            this.incDay.Click += new System.EventHandler(this.incDay_Click);
            // 
            // dayLbl
            // 
            this.dayLbl.AutoSize = true;
            this.dayLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dayLbl.Location = new System.Drawing.Point(329, 63);
            this.dayLbl.Name = "dayLbl";
            this.dayLbl.Size = new System.Drawing.Size(21, 15);
            this.dayLbl.TabIndex = 73;
            this.dayLbl.Text = "50";
            // 
            // dayTB
            // 
            this.dayTB.BackColor = System.Drawing.SystemColors.Control;
            this.dayTB.LargeChange = 1;
            this.dayTB.Location = new System.Drawing.Point(27, 60);
            this.dayTB.Maximum = 100;
            this.dayTB.Minimum = 1;
            this.dayTB.Name = "dayTB";
            this.dayTB.Size = new System.Drawing.Size(243, 45);
            this.dayTB.TabIndex = 72;
            this.dayTB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.dayTB.Value = 50;
            this.dayTB.ValueChanged += new System.EventHandler(this.dayTB_ValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // nightCheckB
            // 
            this.nightCheckB.AutoSize = true;
            this.nightCheckB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.nightCheckB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nightCheckB.Location = new System.Drawing.Point(14, 179);
            this.nightCheckB.Name = "nightCheckB";
            this.nightCheckB.Size = new System.Drawing.Size(62, 19);
            this.nightCheckB.TabIndex = 71;
            this.nightCheckB.Text = "Nights";
            this.nightCheckB.UseVisualStyleBackColor = true;
            this.nightCheckB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // nightGroupBox
            // 
            this.nightGroupBox.Controls.Add(this.nightGradual);
            this.nightGroupBox.Controls.Add(this.label11);
            this.nightGroupBox.Controls.Add(this.label12);
            this.nightGroupBox.Controls.Add(this.dtPickNight);
            this.nightGroupBox.Controls.Add(this.decNight);
            this.nightGroupBox.Controls.Add(this.incNight);
            this.nightGroupBox.Controls.Add(this.nightLbl);
            this.nightGroupBox.Controls.Add(this.nightTB);
            this.nightGroupBox.Controls.Add(this.pictureBox3);
            this.nightGroupBox.Enabled = false;
            this.nightGroupBox.Location = new System.Drawing.Point(14, 204);
            this.nightGroupBox.Name = "nightGroupBox";
            this.nightGroupBox.Size = new System.Drawing.Size(362, 108);
            this.nightGroupBox.TabIndex = 72;
            this.nightGroupBox.TabStop = false;
            // 
            // nightGradual
            // 
            this.nightGradual.AutoSize = true;
            this.nightGradual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.nightGradual.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nightGradual.Location = new System.Drawing.Point(110, 38);
            this.nightGradual.Name = "nightGradual";
            this.nightGradual.Size = new System.Drawing.Size(15, 14);
            this.nightGradual.TabIndex = 73;
            this.nightGradual.UseVisualStyleBackColor = true;
            this.nightGradual.CheckedChanged += new System.EventHandler(this.nightGradual_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(4, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 15);
            this.label11.TabIndex = 77;
            this.label11.Text = "Gradual Change?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(4, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 15);
            this.label12.TabIndex = 76;
            this.label12.Text = "Time of Effect";
            // 
            // dtPickNight
            // 
            this.dtPickNight.CustomFormat = "hh:mm:ss tt";
            this.dtPickNight.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickNight.Location = new System.Drawing.Point(110, 10);
            this.dtPickNight.Name = "dtPickNight";
            this.dtPickNight.ShowUpDown = true;
            this.dtPickNight.Size = new System.Drawing.Size(97, 20);
            this.dtPickNight.TabIndex = 70;
            this.dtPickNight.Value = new System.DateTime(2015, 12, 30, 0, 0, 0, 0);
            this.dtPickNight.ValueChanged += new System.EventHandler(this.dtPickNight_ValueChanged);
            // 
            // decNight
            // 
            this.decNight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decNight.Location = new System.Drawing.Point(268, 59);
            this.decNight.Name = "decNight";
            this.decNight.Size = new System.Drawing.Size(26, 23);
            this.decNight.TabIndex = 75;
            this.decNight.Text = "-";
            this.decNight.UseVisualStyleBackColor = true;
            this.decNight.Click += new System.EventHandler(this.decNight_Click);
            // 
            // incNight
            // 
            this.incNight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incNight.Location = new System.Drawing.Point(298, 59);
            this.incNight.Name = "incNight";
            this.incNight.Size = new System.Drawing.Size(26, 23);
            this.incNight.TabIndex = 74;
            this.incNight.Text = "+";
            this.incNight.UseVisualStyleBackColor = true;
            this.incNight.Click += new System.EventHandler(this.incNight_Click);
            // 
            // nightLbl
            // 
            this.nightLbl.AutoSize = true;
            this.nightLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nightLbl.Location = new System.Drawing.Point(329, 63);
            this.nightLbl.Name = "nightLbl";
            this.nightLbl.Size = new System.Drawing.Size(21, 15);
            this.nightLbl.TabIndex = 73;
            this.nightLbl.Text = "50";
            // 
            // nightTB
            // 
            this.nightTB.BackColor = System.Drawing.SystemColors.Control;
            this.nightTB.LargeChange = 1;
            this.nightTB.Location = new System.Drawing.Point(27, 60);
            this.nightTB.Maximum = 100;
            this.nightTB.Minimum = 1;
            this.nightTB.Name = "nightTB";
            this.nightTB.Size = new System.Drawing.Size(243, 45);
            this.nightTB.TabIndex = 72;
            this.nightTB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.nightTB.Value = 50;
            this.nightTB.ValueChanged += new System.EventHandler(this.nightTB_ValueChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 71;
            this.pictureBox3.TabStop = false;
            // 
            // systemTimeTimer
            // 
            this.systemTimeTimer.Enabled = true;
            this.systemTimeTimer.Interval = 1000;
            this.systemTimeTimer.Tick += new System.EventHandler(this.systemTimeTimer_Tick);
            // 
            // startupCB
            // 
            this.startupCB.AutoSize = true;
            this.startupCB.Location = new System.Drawing.Point(93, 37);
            this.startupCB.Name = "startupCB";
            this.startupCB.Size = new System.Drawing.Size(15, 14);
            this.startupCB.TabIndex = 73;
            this.startupCB.UseVisualStyleBackColor = true;
            this.startupCB.CheckedChanged += new System.EventHandler(this.startupCB_CheckedChanged);
            // 
            // trayBox
            // 
            this.trayBox.AutoSize = true;
            this.trayBox.Location = new System.Drawing.Point(93, 57);
            this.trayBox.Name = "trayBox";
            this.trayBox.Size = new System.Drawing.Size(15, 14);
            this.trayBox.TabIndex = 74;
            this.trayBox.UseVisualStyleBackColor = true;
            this.trayBox.CheckedChanged += new System.EventHandler(this.trayBox_CheckedChanged);
            // 
            // disableBtn
            // 
            this.disableBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.disableBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.disableBtn.Location = new System.Drawing.Point(15, 604);
            this.disableBtn.Name = "disableBtn";
            this.disableBtn.Size = new System.Drawing.Size(391, 23);
            this.disableBtn.TabIndex = 75;
            this.disableBtn.Text = "Disable (Remove Tray, Remove Startup, Max Brightness)";
            this.disableBtn.UseVisualStyleBackColor = true;
            this.disableBtn.Click += new System.EventHandler(this.disableBtn_Click);
            // 
            // masterGroupBox
            // 
            this.masterGroupBox.Controls.Add(this.decBtn);
            this.masterGroupBox.Controls.Add(this.masterLbl);
            this.masterGroupBox.Controls.Add(this.brightnessTrack);
            this.masterGroupBox.Controls.Add(this.brightnessLabel);
            this.masterGroupBox.Controls.Add(this.pictureBox1);
            this.masterGroupBox.Controls.Add(this.incBtn);
            this.masterGroupBox.Controls.Add(this.masterCollapseBtn);
            this.masterGroupBox.Location = new System.Drawing.Point(14, 82);
            this.masterGroupBox.Name = "masterGroupBox";
            this.masterGroupBox.Size = new System.Drawing.Size(392, 113);
            this.masterGroupBox.TabIndex = 76;
            this.masterGroupBox.TabStop = false;
            // 
            // masterCollapseBtn
            // 
            this.masterCollapseBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.masterCollapseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.masterCollapseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.masterCollapseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.masterCollapseBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.masterCollapseBtn.Location = new System.Drawing.Point(1, 7);
            this.masterCollapseBtn.Name = "masterCollapseBtn";
            this.masterCollapseBtn.Size = new System.Drawing.Size(391, 23);
            this.masterCollapseBtn.TabIndex = 79;
            this.masterCollapseBtn.UseVisualStyleBackColor = false;
            this.masterCollapseBtn.Click += new System.EventHandler(this.button6_Click);
            this.masterCollapseBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.masterCollapseBtn_MouseDown);
            this.masterCollapseBtn.MouseEnter += new System.EventHandler(this.masterCollapseBtn_MouseEnter);
            this.masterCollapseBtn.MouseLeave += new System.EventHandler(this.masterCollapseBtn_MouseLeave);
            this.masterCollapseBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.masterCollapseBtn_MouseUp);
            // 
            // schedulerGroupbBox
            // 
            this.schedulerGroupbBox.Controls.Add(this.schedulerLbl);
            this.schedulerGroupbBox.Controls.Add(this.dayGroupBox);
            this.schedulerGroupbBox.Controls.Add(this.dayCheckB);
            this.schedulerGroupbBox.Controls.Add(this.nightGroupBox);
            this.schedulerGroupbBox.Controls.Add(this.nightCheckB);
            this.schedulerGroupbBox.Controls.Add(this.scheduleCollapseBtn);
            this.schedulerGroupbBox.Location = new System.Drawing.Point(14, 194);
            this.schedulerGroupbBox.Name = "schedulerGroupbBox";
            this.schedulerGroupbBox.Size = new System.Drawing.Size(392, 316);
            this.schedulerGroupbBox.TabIndex = 77;
            this.schedulerGroupbBox.TabStop = false;
            // 
            // scheduleCollapseBtn
            // 
            this.scheduleCollapseBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.scheduleCollapseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.scheduleCollapseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.scheduleCollapseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scheduleCollapseBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.scheduleCollapseBtn.Location = new System.Drawing.Point(1, 7);
            this.scheduleCollapseBtn.Name = "scheduleCollapseBtn";
            this.scheduleCollapseBtn.Size = new System.Drawing.Size(391, 23);
            this.scheduleCollapseBtn.TabIndex = 78;
            this.scheduleCollapseBtn.UseVisualStyleBackColor = false;
            this.scheduleCollapseBtn.Click += new System.EventHandler(this.scheduleCollapseBtn_Click);
            this.scheduleCollapseBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scheduleCollapseBtn_MouseDown);
            this.scheduleCollapseBtn.MouseEnter += new System.EventHandler(this.scheduleCollapseBtn_MouseEnter);
            this.scheduleCollapseBtn.MouseLeave += new System.EventHandler(this.scheduleCollapseBtn_MouseLeave);
            this.scheduleCollapseBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.scheduleCollapseBtn_MouseUp);
            // 
            // otherGroupBox
            // 
            this.otherGroupBox.Controls.Add(this.otherLbl);
            this.otherGroupBox.Controls.Add(this.otherCollapseBtn);
            this.otherGroupBox.Controls.Add(this.label5);
            this.otherGroupBox.Controls.Add(this.label6);
            this.otherGroupBox.Controls.Add(this.startupCB);
            this.otherGroupBox.Controls.Add(this.trayBox);
            this.otherGroupBox.Location = new System.Drawing.Point(14, 512);
            this.otherGroupBox.Name = "otherGroupBox";
            this.otherGroupBox.Size = new System.Drawing.Size(392, 86);
            this.otherGroupBox.TabIndex = 78;
            this.otherGroupBox.TabStop = false;
            // 
            // otherLbl
            // 
            this.otherLbl.AutoSize = true;
            this.otherLbl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.otherLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.otherLbl.Location = new System.Drawing.Point(6, 8);
            this.otherLbl.Name = "otherLbl";
            this.otherLbl.Size = new System.Drawing.Size(86, 15);
            this.otherLbl.TabIndex = 79;
            this.otherLbl.Text = "Other Options";
            // 
            // otherCollapseBtn
            // 
            this.otherCollapseBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.otherCollapseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.otherCollapseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.otherCollapseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otherCollapseBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.otherCollapseBtn.Location = new System.Drawing.Point(1, 4);
            this.otherCollapseBtn.Name = "otherCollapseBtn";
            this.otherCollapseBtn.Size = new System.Drawing.Size(391, 23);
            this.otherCollapseBtn.TabIndex = 79;
            this.otherCollapseBtn.UseVisualStyleBackColor = false;
            this.otherCollapseBtn.Click += new System.EventHandler(this.otherCollapseBtn_Click);
            this.otherCollapseBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.otherCollapseBtn_MouseDown);
            this.otherCollapseBtn.MouseEnter += new System.EventHandler(this.otherCollapseBtn_MouseEnter);
            this.otherCollapseBtn.MouseLeave += new System.EventHandler(this.otherCollapseBtn_MouseLeave);
            this.otherCollapseBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.otherCollapseBtn_MouseUp);
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.trayIcon.BalloonTipText = "Brightness Modifier";
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Visible = true;
            this.trayIcon.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // currentBrightnessLbl
            // 
            this.currentBrightnessLbl.AutoSize = true;
            this.currentBrightnessLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBrightnessLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.currentBrightnessLbl.Location = new System.Drawing.Point(51, 141);
            this.currentBrightnessLbl.Name = "currentBrightnessLbl";
            this.currentBrightnessLbl.Size = new System.Drawing.Size(232, 30);
            this.currentBrightnessLbl.TabIndex = 79;
            this.currentBrightnessLbl.Text = "Current Brightness: 50";
            // 
            // dayBackLbl
            // 
            this.dayBackLbl.AutoSize = true;
            this.dayBackLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayBackLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dayBackLbl.Location = new System.Drawing.Point(51, 241);
            this.dayBackLbl.Name = "dayBackLbl";
            this.dayBackLbl.Size = new System.Drawing.Size(198, 30);
            this.dayBackLbl.TabIndex = 80;
            this.dayBackLbl.Text = "Day Scheduler: Off";
            // 
            // dayBackTime
            // 
            this.dayBackTime.AutoSize = true;
            this.dayBackTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayBackTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dayBackTime.Location = new System.Drawing.Point(102, 270);
            this.dayBackTime.Name = "dayBackTime";
            this.dayBackTime.Size = new System.Drawing.Size(247, 30);
            this.dayBackTime.TabIndex = 81;
            this.dayBackTime.Text = "Scheduled Time: 12:00:00";
            // 
            // dayBackBrightness
            // 
            this.dayBackBrightness.AutoSize = true;
            this.dayBackBrightness.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayBackBrightness.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dayBackBrightness.Location = new System.Drawing.Point(102, 303);
            this.dayBackBrightness.Name = "dayBackBrightness";
            this.dayBackBrightness.Size = new System.Drawing.Size(177, 30);
            this.dayBackBrightness.TabIndex = 82;
            this.dayBackBrightness.Text = "Set Brightness: 50";
            // 
            // dayBackGradual
            // 
            this.dayBackGradual.AutoSize = true;
            this.dayBackGradual.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayBackGradual.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dayBackGradual.Location = new System.Drawing.Point(102, 338);
            this.dayBackGradual.Name = "dayBackGradual";
            this.dayBackGradual.Size = new System.Drawing.Size(203, 30);
            this.dayBackGradual.TabIndex = 83;
            this.dayBackGradual.Text = "Gradual Change: Off";
            // 
            // nightBackGradual
            // 
            this.nightBackGradual.AutoSize = true;
            this.nightBackGradual.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightBackGradual.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nightBackGradual.Location = new System.Drawing.Point(102, 467);
            this.nightBackGradual.Name = "nightBackGradual";
            this.nightBackGradual.Size = new System.Drawing.Size(203, 30);
            this.nightBackGradual.TabIndex = 87;
            this.nightBackGradual.Text = "Gradual Change: Off";
            // 
            // nightBackBrightness
            // 
            this.nightBackBrightness.AutoSize = true;
            this.nightBackBrightness.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightBackBrightness.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nightBackBrightness.Location = new System.Drawing.Point(102, 432);
            this.nightBackBrightness.Name = "nightBackBrightness";
            this.nightBackBrightness.Size = new System.Drawing.Size(177, 30);
            this.nightBackBrightness.TabIndex = 86;
            this.nightBackBrightness.Text = "Set Brightness: 50";
            // 
            // nightBackTime
            // 
            this.nightBackTime.AutoSize = true;
            this.nightBackTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightBackTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nightBackTime.Location = new System.Drawing.Point(102, 399);
            this.nightBackTime.Name = "nightBackTime";
            this.nightBackTime.Size = new System.Drawing.Size(247, 30);
            this.nightBackTime.TabIndex = 85;
            this.nightBackTime.Text = "Scheduled Time: 12:00:00";
            // 
            // nightBackLbl
            // 
            this.nightBackLbl.AutoSize = true;
            this.nightBackLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightBackLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nightBackLbl.Location = new System.Drawing.Point(51, 370);
            this.nightBackLbl.Name = "nightBackLbl";
            this.nightBackLbl.Size = new System.Drawing.Size(218, 30);
            this.nightBackLbl.TabIndex = 84;
            this.nightBackLbl.Text = "Night Scheduler: Off";
            // 
            // startBackLbl
            // 
            this.startBackLbl.AutoSize = true;
            this.startBackLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBackLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.startBackLbl.Location = new System.Drawing.Point(51, 539);
            this.startBackLbl.Name = "startBackLbl";
            this.startBackLbl.Size = new System.Drawing.Size(128, 30);
            this.startBackLbl.TabIndex = 88;
            this.startBackLbl.Text = "Startup: No";
            // 
            // trayBackLbl
            // 
            this.trayBackLbl.AutoSize = true;
            this.trayBackLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayBackLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.trayBackLbl.Location = new System.Drawing.Point(51, 567);
            this.trayBackLbl.Name = "trayBackLbl";
            this.trayBackLbl.Size = new System.Drawing.Size(96, 30);
            this.trayBackLbl.TabIndex = 89;
            this.trayBackLbl.Text = "Tray: Yes";
            // 
            // BrightnessModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 658);
            this.Controls.Add(this.otherGroupBox);
            this.Controls.Add(this.schedulerGroupbBox);
            this.Controls.Add(this.masterGroupBox);
            this.Controls.Add(this.disableBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.threatBox);
            this.Controls.Add(this.currentBrightnessLbl);
            this.Controls.Add(this.nightBackGradual);
            this.Controls.Add(this.nightBackBrightness);
            this.Controls.Add(this.nightBackTime);
            this.Controls.Add(this.nightBackLbl);
            this.Controls.Add(this.dayBackGradual);
            this.Controls.Add(this.dayBackBrightness);
            this.Controls.Add(this.dayBackTime);
            this.Controls.Add(this.dayBackLbl);
            this.Controls.Add(this.trayBackLbl);
            this.Controls.Add(this.startBackLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BrightnessModifier";
            this.Text = "Brightness Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BrightnessModifier_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BrightnessModifier_FormClosed);
            this.Resize += new System.EventHandler(this.BrightnessModifier_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threatBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.dayGroupBox.ResumeLayout(false);
            this.dayGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.nightGroupBox.ResumeLayout(false);
            this.nightGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nightTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.masterGroupBox.ResumeLayout(false);
            this.masterGroupBox.PerformLayout();
            this.schedulerGroupbBox.ResumeLayout(false);
            this.schedulerGroupbBox.PerformLayout();
            this.otherGroupBox.ResumeLayout(false);
            this.otherGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar brightnessTrack;
        private System.Windows.Forms.PictureBox threatBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusBar;
        private System.Windows.Forms.LinkLabel tFixLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button incBtn;
        private System.Windows.Forms.Button decBtn;
        private System.Windows.Forms.Label masterLbl;
        private System.Windows.Forms.Label schedulerLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox dayCheckB;
        private System.Windows.Forms.GroupBox dayGroupBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtPickDay;
        private System.Windows.Forms.Button decDay;
        private System.Windows.Forms.Button incDay;
        private System.Windows.Forms.Label dayLbl;
        private System.Windows.Forms.TrackBar dayTB;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox nightCheckB;
        private System.Windows.Forms.GroupBox nightGroupBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtPickNight;
        private System.Windows.Forms.Button decNight;
        private System.Windows.Forms.Button incNight;
        private System.Windows.Forms.Label nightLbl;
        private System.Windows.Forms.TrackBar nightTB;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox dayGradual;
        private System.Windows.Forms.CheckBox nightGradual;
        private System.Windows.Forms.Timer systemTimeTimer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox startupCB;
        private System.Windows.Forms.CheckBox trayBox;
        private System.Windows.Forms.Button disableBtn;
        private System.Windows.Forms.GroupBox masterGroupBox;
        private System.Windows.Forms.Button masterCollapseBtn;
        private System.Windows.Forms.GroupBox schedulerGroupbBox;
        private System.Windows.Forms.Button scheduleCollapseBtn;
        private System.Windows.Forms.GroupBox otherGroupBox;
        private System.Windows.Forms.Button otherCollapseBtn;
        private System.Windows.Forms.Label otherLbl;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.Label currentBrightnessLbl;
        private System.Windows.Forms.Label dayBackLbl;
        private System.Windows.Forms.Label dayBackTime;
        private System.Windows.Forms.Label dayBackBrightness;
        private System.Windows.Forms.Label dayBackGradual;
        private System.Windows.Forms.Label nightBackGradual;
        private System.Windows.Forms.Label nightBackBrightness;
        private System.Windows.Forms.Label nightBackTime;
        private System.Windows.Forms.Label nightBackLbl;
        private System.Windows.Forms.Label startBackLbl;
        private System.Windows.Forms.Label trayBackLbl;
        private System.Windows.Forms.Label systemTime;
    }
}

