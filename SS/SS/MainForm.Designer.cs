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
            this.tfDestinationFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fdSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.nudSavePeriodicaly = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSettings = new System.Windows.Forms.Label();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.dpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dpEndDate = new System.Windows.Forms.DateTimePicker();
            this.gbWeek = new System.Windows.Forms.GroupBox();
            this.cbSunday = new System.Windows.Forms.CheckBox();
            this.cbSaturday = new System.Windows.Forms.CheckBox();
            this.cbFriday = new System.Windows.Forms.CheckBox();
            this.cbThursday = new System.Windows.Forms.CheckBox();
            this.cbWednesday = new System.Windows.Forms.CheckBox();
            this.chThuesday = new System.Windows.Forms.CheckBox();
            this.cbMonday = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudSavePeriodicaly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbTime.SuspendLayout();
            this.gbWeek.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Откорой SS";
            this.notifyIcon1.Visible = true;
            // 
            // tfDestinationFolder
            // 
            this.tfDestinationFolder.Location = new System.Drawing.Point(174, 29);
            this.tfDestinationFolder.Name = "tfDestinationFolder";
            this.tfDestinationFolder.Size = new System.Drawing.Size(100, 20);
            this.tfDestinationFolder.TabIndex = 0;
            this.tfDestinationFolder.Text = "c:/ss_default";
            this.tfDestinationFolder.Click += new System.EventHandler(this.TFDestinationFolder_Click);
            this.tfDestinationFolder.TextChanged += new System.EventHandler(this.tfDestinationFolder_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destination path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Save periodicity";
            // 
            // nudSavePeriodicaly
            // 
            this.nudSavePeriodicaly.Location = new System.Drawing.Point(174, 79);
            this.nudSavePeriodicaly.Name = "nudSavePeriodicaly";
            this.nudSavePeriodicaly.Size = new System.Drawing.Size(100, 20);
            this.nudSavePeriodicaly.TabIndex = 3;
            this.nudSavePeriodicaly.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSavePeriodicaly.ValueChanged += new System.EventHandler(this.nudSavePeriodicaly_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "minutes";
            // 
            // splitContainer1
            // 
            this.splitContainer1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbTime);
            this.splitContainer1.Panel2.Controls.Add(this.gbWeek);
            this.splitContainer1.Size = new System.Drawing.Size(760, 397);
            this.splitContainer1.SplitterDistance = 426;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.tfDestinationFolder);
            this.splitContainer2.Panel1.Controls.Add(this.nudSavePeriodicaly);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.btnStart);
            this.splitContainer2.Panel2.Controls.Add(this.lblSettings);
            this.splitContainer2.Size = new System.Drawing.Size(426, 397);
            this.splitContainer2.SplitterDistance = 198;
            this.splitContainer2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(283, 107);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Stop";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Location = new System.Drawing.Point(53, 32);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(35, 13);
            this.lblSettings.TabIndex = 0;
            this.lblSettings.Text = "label4";
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.dpStartDate);
            this.gbTime.Controls.Add(this.dpEndDate);
            this.gbTime.Location = new System.Drawing.Point(15, 222);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(292, 110);
            this.gbTime.TabIndex = 3;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "Select time range to save screenshorts";
            // 
            // dpStartDate
            // 
            this.dpStartDate.CustomFormat = "HH:mm";
            this.dpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpStartDate.Location = new System.Drawing.Point(7, 40);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.ShowUpDown = true;
            this.dpStartDate.Size = new System.Drawing.Size(58, 20);
            this.dpStartDate.TabIndex = 1;
            this.dpStartDate.Value = new System.DateTime(2016, 12, 28, 9, 30, 0, 0);
            this.dpStartDate.ValueChanged += new System.EventHandler(this.dpStartDate_ValueChanged);
            // 
            // dpEndDate
            // 
            this.dpEndDate.CustomFormat = "HH:mm";
            this.dpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpEndDate.Location = new System.Drawing.Point(95, 40);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.ShowUpDown = true;
            this.dpEndDate.Size = new System.Drawing.Size(52, 20);
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
            this.gbWeek.Controls.Add(this.chThuesday);
            this.gbWeek.Controls.Add(this.cbMonday);
            this.gbWeek.Location = new System.Drawing.Point(15, 29);
            this.gbWeek.Name = "gbWeek";
            this.gbWeek.Size = new System.Drawing.Size(292, 162);
            this.gbWeek.TabIndex = 0;
            this.gbWeek.TabStop = false;
            this.gbWeek.Text = "Select dates to save screenshorts";
            // 
            // cbSunday
            // 
            this.cbSunday.AutoSize = true;
            this.cbSunday.Location = new System.Drawing.Point(138, 57);
            this.cbSunday.Name = "cbSunday";
            this.cbSunday.Size = new System.Drawing.Size(62, 17);
            this.cbSunday.TabIndex = 6;
            this.cbSunday.Text = "Sanday";
            this.cbSunday.UseVisualStyleBackColor = true;
            // 
            // cbSaturday
            // 
            this.cbSaturday.AutoSize = true;
            this.cbSaturday.Location = new System.Drawing.Point(138, 29);
            this.cbSaturday.Name = "cbSaturday";
            this.cbSaturday.Size = new System.Drawing.Size(68, 17);
            this.cbSaturday.TabIndex = 5;
            this.cbSaturday.Text = "Saturday";
            this.cbSaturday.UseVisualStyleBackColor = true;
            // 
            // cbFriday
            // 
            this.cbFriday.AutoSize = true;
            this.cbFriday.Checked = true;
            this.cbFriday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFriday.Location = new System.Drawing.Point(7, 132);
            this.cbFriday.Name = "cbFriday";
            this.cbFriday.Size = new System.Drawing.Size(54, 17);
            this.cbFriday.TabIndex = 4;
            this.cbFriday.Text = "Friday";
            this.cbFriday.UseVisualStyleBackColor = true;
            // 
            // cbThursday
            // 
            this.cbThursday.AutoSize = true;
            this.cbThursday.Checked = true;
            this.cbThursday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbThursday.Location = new System.Drawing.Point(7, 104);
            this.cbThursday.Name = "cbThursday";
            this.cbThursday.Size = new System.Drawing.Size(70, 17);
            this.cbThursday.TabIndex = 3;
            this.cbThursday.Text = "Thursday";
            this.cbThursday.UseVisualStyleBackColor = true;
            // 
            // cbWednesday
            // 
            this.cbWednesday.AutoSize = true;
            this.cbWednesday.Checked = true;
            this.cbWednesday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWednesday.Location = new System.Drawing.Point(7, 81);
            this.cbWednesday.Name = "cbWednesday";
            this.cbWednesday.Size = new System.Drawing.Size(83, 17);
            this.cbWednesday.TabIndex = 2;
            this.cbWednesday.Text = "Wednesday";
            this.cbWednesday.UseVisualStyleBackColor = true;
            // 
            // chThuesday
            // 
            this.chThuesday.AutoSize = true;
            this.chThuesday.Checked = true;
            this.chThuesday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chThuesday.Location = new System.Drawing.Point(7, 57);
            this.chThuesday.Name = "chThuesday";
            this.chThuesday.Size = new System.Drawing.Size(73, 17);
            this.chThuesday.TabIndex = 1;
            this.chThuesday.Text = "Thuesday";
            this.chThuesday.UseVisualStyleBackColor = true;
            // 
            // cbMonday
            // 
            this.cbMonday.AutoSize = true;
            this.cbMonday.Checked = true;
            this.cbMonday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMonday.Location = new System.Drawing.Point(7, 29);
            this.cbMonday.Name = "cbMonday";
            this.cbMonday.Size = new System.Drawing.Size(64, 17);
            this.cbMonday.TabIndex = 0;
            this.cbMonday.Text = "Monday";
            this.cbMonday.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 397);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSavePeriodicaly)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbTime.ResumeLayout(false);
            this.gbWeek.ResumeLayout(false);
            this.gbWeek.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox tfDestinationFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog fdSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudSavePeriodicaly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dpEndDate;
        private System.Windows.Forms.DateTimePicker dpStartDate;
        private System.Windows.Forms.GroupBox gbWeek;
        private System.Windows.Forms.CheckBox cbSunday;
        private System.Windows.Forms.CheckBox cbSaturday;
        private System.Windows.Forms.CheckBox cbFriday;
        private System.Windows.Forms.CheckBox cbThursday;
        private System.Windows.Forms.CheckBox cbWednesday;
        private System.Windows.Forms.CheckBox chThuesday;
        private System.Windows.Forms.CheckBox cbMonday;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.Label label4;
    }
}

