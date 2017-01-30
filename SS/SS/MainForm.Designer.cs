namespace SS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fdSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.dpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dpEndDate = new System.Windows.Forms.DateTimePicker();
            this.gbWeek = new System.Windows.Forms.GroupBox();
            this.cbSunday = new System.Windows.Forms.CheckBox();
            this.cbSaturday = new System.Windows.Forms.CheckBox();
            this.cbFriday = new System.Windows.Forms.CheckBox();
            this.cbThursday = new System.Windows.Forms.CheckBox();
            this.cbWednesday = new System.Windows.Forms.CheckBox();
            this.cbTuesday = new System.Windows.Forms.CheckBox();
            this.cbMonday = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSavePeriodicaly = new System.Windows.Forms.NumericUpDown();
            this.tfDestinationFolder = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbSavedPicture = new System.Windows.Forms.PictureBox();
            this.pbStatus = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.trayContextMenu.SuspendLayout();
            this.gbTime.SuspendLayout();
            this.gbWeek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSavePeriodicaly)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSavedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.trayContextMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Откорой SS";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.trayContextMenu.Name = "trayContextMenu";
            this.trayContextMenu.Size = new System.Drawing.Size(104, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.dpStartDate);
            this.gbTime.Controls.Add(this.dpEndDate);
            this.gbTime.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTime.Location = new System.Drawing.Point(18, 198);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(292, 110);
            this.gbTime.TabIndex = 3;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "Select time range to save screenshorts";
            // 
            // dpStartDate
            // 
            this.dpStartDate.CustomFormat = "HH:mm";
            this.dpStartDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpStartDate.Location = new System.Drawing.Point(23, 50);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.ShowUpDown = true;
            this.dpStartDate.Size = new System.Drawing.Size(82, 23);
            this.dpStartDate.TabIndex = 1;
            this.dpStartDate.Value = new System.DateTime(2016, 12, 28, 9, 30, 0, 0);
            this.dpStartDate.ValueChanged += new System.EventHandler(this.dpStartDate_ValueChanged);
            // 
            // dpEndDate
            // 
            this.dpEndDate.CustomFormat = "HH:mm";
            this.dpEndDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpEndDate.Location = new System.Drawing.Point(154, 50);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.ShowUpDown = true;
            this.dpEndDate.Size = new System.Drawing.Size(74, 23);
            this.dpEndDate.TabIndex = 2;
            this.dpEndDate.Value = new System.DateTime(2016, 12, 28, 18, 30, 0, 0);
            this.dpEndDate.ValueChanged += new System.EventHandler(this.dpEndDate_ValueChanged);
            // 
            // gbWeek
            // 
            this.gbWeek.Controls.Add(this.cbSunday);
            this.gbWeek.Controls.Add(this.cbSaturday);
            this.gbWeek.Controls.Add(this.cbFriday);
            this.gbWeek.Controls.Add(this.cbThursday);
            this.gbWeek.Controls.Add(this.cbWednesday);
            this.gbWeek.Controls.Add(this.cbTuesday);
            this.gbWeek.Controls.Add(this.cbMonday);
            this.gbWeek.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbWeek.Location = new System.Drawing.Point(18, 12);
            this.gbWeek.Name = "gbWeek";
            this.gbWeek.Size = new System.Drawing.Size(292, 162);
            this.gbWeek.TabIndex = 0;
            this.gbWeek.TabStop = false;
            this.gbWeek.Text = "Select dates to save screenshorts";
            // 
            // cbSunday
            // 
            this.cbSunday.AutoSize = true;
            this.cbSunday.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSunday.Location = new System.Drawing.Point(138, 57);
            this.cbSunday.Name = "cbSunday";
            this.cbSunday.Size = new System.Drawing.Size(75, 20);
            this.cbSunday.TabIndex = 6;
            this.cbSunday.Text = "Sanday";
            this.cbSunday.UseVisualStyleBackColor = true;
            this.cbSunday.CheckedChanged += new System.EventHandler(this.cbWeekDay_CheckedChanged);
            // 
            // cbSaturday
            // 
            this.cbSaturday.AutoSize = true;
            this.cbSaturday.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSaturday.Location = new System.Drawing.Point(138, 29);
            this.cbSaturday.Name = "cbSaturday";
            this.cbSaturday.Size = new System.Drawing.Size(84, 20);
            this.cbSaturday.TabIndex = 5;
            this.cbSaturday.Text = "Saturday";
            this.cbSaturday.UseVisualStyleBackColor = true;
            this.cbSaturday.CheckedChanged += new System.EventHandler(this.cbWeekDay_CheckedChanged);
            // 
            // cbFriday
            // 
            this.cbFriday.AutoSize = true;
            this.cbFriday.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFriday.Location = new System.Drawing.Point(7, 132);
            this.cbFriday.Name = "cbFriday";
            this.cbFriday.Size = new System.Drawing.Size(67, 20);
            this.cbFriday.TabIndex = 4;
            this.cbFriday.Text = "Friday";
            this.cbFriday.UseVisualStyleBackColor = true;
            this.cbFriday.CheckedChanged += new System.EventHandler(this.cbWeekDay_CheckedChanged);
            // 
            // cbThursday
            // 
            this.cbThursday.AutoSize = true;
            this.cbThursday.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbThursday.Location = new System.Drawing.Point(7, 104);
            this.cbThursday.Name = "cbThursday";
            this.cbThursday.Size = new System.Drawing.Size(87, 20);
            this.cbThursday.TabIndex = 3;
            this.cbThursday.Text = "Thursday";
            this.cbThursday.UseVisualStyleBackColor = true;
            this.cbThursday.CheckedChanged += new System.EventHandler(this.cbWeekDay_CheckedChanged);
            // 
            // cbWednesday
            // 
            this.cbWednesday.AutoSize = true;
            this.cbWednesday.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbWednesday.Location = new System.Drawing.Point(7, 81);
            this.cbWednesday.Name = "cbWednesday";
            this.cbWednesday.Size = new System.Drawing.Size(102, 20);
            this.cbWednesday.TabIndex = 2;
            this.cbWednesday.Text = "Wednesday";
            this.cbWednesday.UseVisualStyleBackColor = true;
            this.cbWednesday.CheckedChanged += new System.EventHandler(this.cbWeekDay_CheckedChanged);
            // 
            // cbTuesday
            // 
            this.cbTuesday.AutoSize = true;
            this.cbTuesday.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTuesday.Location = new System.Drawing.Point(7, 57);
            this.cbTuesday.Name = "cbTuesday";
            this.cbTuesday.Size = new System.Drawing.Size(81, 20);
            this.cbTuesday.TabIndex = 1;
            this.cbTuesday.Text = "Tuesday";
            this.cbTuesday.UseVisualStyleBackColor = true;
            this.cbTuesday.CheckedChanged += new System.EventHandler(this.cbWeekDay_CheckedChanged);
            // 
            // cbMonday
            // 
            this.cbMonday.AutoSize = true;
            this.cbMonday.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbMonday.Location = new System.Drawing.Point(7, 29);
            this.cbMonday.Name = "cbMonday";
            this.cbMonday.Size = new System.Drawing.Size(77, 20);
            this.cbMonday.TabIndex = 0;
            this.cbMonday.Text = "Monday";
            this.cbMonday.UseVisualStyleBackColor = true;
            this.cbMonday.CheckedChanged += new System.EventHandler(this.cbWeekDay_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Save periodicity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "minutes";
            // 
            // nudSavePeriodicaly
            // 
            this.nudSavePeriodicaly.Location = new System.Drawing.Point(187, 81);
            this.nudSavePeriodicaly.Name = "nudSavePeriodicaly";
            this.nudSavePeriodicaly.Size = new System.Drawing.Size(100, 23);
            this.nudSavePeriodicaly.TabIndex = 3;
            this.nudSavePeriodicaly.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSavePeriodicaly.ValueChanged += new System.EventHandler(this.nudSavePeriodicaly_ValueChanged);
            // 
            // tfDestinationFolder
            // 
            this.tfDestinationFolder.Location = new System.Drawing.Point(187, 12);
            this.tfDestinationFolder.Name = "tfDestinationFolder";
            this.tfDestinationFolder.Size = new System.Drawing.Size(184, 23);
            this.tfDestinationFolder.TabIndex = 0;
            this.tfDestinationFolder.Click += new System.EventHandler(this.TFDestinationFolder_Click);
            this.tfDestinationFolder.TextChanged += new System.EventHandler(this.tfDestinationFolder_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(30, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(111, 16);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Destination path";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.tfDestinationFolder);
            this.panel1.Controls.Add(this.nudSavePeriodicaly);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(399, 175);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.pbSavedPicture);
            this.panel2.Controls.Add(this.pbStatus);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 143);
            this.panel2.TabIndex = 7;
            // 
            // pbSavedPicture
            // 
            this.pbSavedPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSavedPicture.BackgroundImage")));
            this.pbSavedPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSavedPicture.Location = new System.Drawing.Point(33, 51);
            this.pbSavedPicture.Name = "pbSavedPicture";
            this.pbSavedPicture.Size = new System.Drawing.Size(338, 76);
            this.pbSavedPicture.TabIndex = 2;
            this.pbSavedPicture.TabStop = false;
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(117, 17);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(21, 20);
            this.pbStatus.TabIndex = 1;
            this.pbStatus.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(144, 21);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(98, 16);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "working status";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.gbTime);
            this.panel3.Controls.Add(this.gbWeek);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(405, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 324);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(399, 324);
            this.panel4.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 324);
            this.ContextMenuStrip = this.trayContextMenu;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(750, 363);
            this.MinimumSize = new System.Drawing.Size(732, 363);
            this.Name = "MainForm";
            this.Text = "Saving Screenshots periodically";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.trayContextMenu.ResumeLayout(false);
            this.gbTime.ResumeLayout(false);
            this.gbWeek.ResumeLayout(false);
            this.gbWeek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSavePeriodicaly)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSavedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.FolderBrowserDialog fdSelector;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dpEndDate;
        private System.Windows.Forms.DateTimePicker dpStartDate;
        private System.Windows.Forms.GroupBox gbWeek;
        private System.Windows.Forms.CheckBox cbSunday;
        private System.Windows.Forms.CheckBox cbSaturday;
        private System.Windows.Forms.CheckBox cbFriday;
        private System.Windows.Forms.CheckBox cbThursday;
        private System.Windows.Forms.CheckBox cbWednesday;
        private System.Windows.Forms.CheckBox cbTuesday;
        private System.Windows.Forms.CheckBox cbMonday;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSavePeriodicaly;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tfDestinationFolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pbStatus;
        public System.Windows.Forms.PictureBox pbSavedPicture;
        private System.Windows.Forms.Label label1;
    }
}

