using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS
{
    public partial class MainForm : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        Thread ssThread;
        public MainForm()
        {
            InitializeComponent();

            //tray icon event
            notifyIcon1.Visible = false;
            this.notifyIcon1.MouseClick += new MouseEventHandler(notifyIcon1_MouseClick);

            //Application event
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            //context menu event
            closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);

            // timer event
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += new EventHandler(SystemEvents_TimeChanged);

            //form event
            this.Resize += new System.EventHandler(this.Form1_Resize);

            UpdateProperties();
            UpdateSettingLabel();
            this.ssThread = new Thread(() => TStart());
            this.ssThread.Start();
        }


         private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         {

            try
            {
                string filePath = tfDestinationFolder.Text.Replace("/", "\\");
                Process.Start("explorer.exe", filePath);
            }
            catch { }
         }

        public void SystemEvents_TimeChanged(object sender, EventArgs e)
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            
            if (currentTime >= Properties.Settings.Default.startTime
                && currentTime <= Properties.Settings.Default.endTime
                && CorrectDayOfWeek())
            {
                label4.Text = "Tread state "+ssThread.ThreadState;
                if (ssThread.ThreadState.Equals(System.Threading.ThreadState.Suspended))
                {
                    try
                    {
                        ssThread.Resume();
                        btnStart.Text = "Stop";
                    }
                    catch
                    {
                        label4.Text = ssThread.IsAlive+" \n something happend, please restart application";
                    }
                }
            }
            else
            {
                label4.Text = String.Format("Time changed: {0}", DateTime.Now);
                if (!ssThread.ThreadState.Equals(System.Threading.ThreadState.Suspended))
                {
                    ssThread.Suspend();
                    btnStart.Text = "Start";
                }
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // проверяем наше окно, и если оно было свернуто, делаем событие        
            if (WindowState == FormWindowState.Minimized)
            {
                // прячем наше окно из панели
                this.ShowInTaskbar = false;
                // делаем нашу иконку в трее активной
                notifyIcon1.Visible = true;
            }
        }
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                notifyIcon1.Visible = false;
                this.ShowInTaskbar = true;
                WindowState = FormWindowState.Normal;
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                trayContextMenu.Show();
            }

           
        }
        
        public string ChooseFolder()
        {
            return fdSelector.SelectedPath;
        }
        private void TFDestinationFolder_Click(object sender, EventArgs e)
        {
            if (fdSelector.ShowDialog() == DialogResult.OK)
            {
                tfDestinationFolder.Text = fdSelector.SelectedPath;
            }
        }
        private void tfDestinationFolder_TextChanged(object sender, EventArgs e)
        {
            UpdateProperties();
            UpdateSettingLabel();
        }

        public void UpdateProperties()
        {
            Properties.Settings.Default.savePeriodical = (int)nudSavePeriodicaly.Value;
            Properties.Settings.Default.destinationPath = tfDestinationFolder.Text;
            Properties.Settings.Default.startTime = dpStartDate.Value.TimeOfDay;
            Properties.Settings.Default.endTime = dpEndDate.Value.TimeOfDay;

            Properties.Settings.Default.Monday = (cbMonday.CheckState == CheckState.Checked) ? true:false;
            Properties.Settings.Default.Thursday = (cbThursday.CheckState == CheckState.Checked) ? true : false;
            Properties.Settings.Default.Wednesday = (cbWednesday.CheckState == CheckState.Checked) ? true : false;
            Properties.Settings.Default.Thursday = (cbThursday.CheckState == CheckState.Checked) ? true : false;
            Properties.Settings.Default.Friday = (cbFriday.CheckState == CheckState.Checked) ? true : false;
            Properties.Settings.Default.Saturday = (cbSaturday.CheckState == CheckState.Checked) ? true : false;
            Properties.Settings.Default.Sunday = (cbSunday.CheckState == CheckState.Checked) ? true : false;
        }
     
        public bool CorrectDayOfWeek()
        {
            string dateOfWeek = DateTime.Now.DayOfWeek.ToString();
            if (Properties.Settings.Default.Monday && dateOfWeek.Equals("Monday"))
                return true;
            if (Properties.Settings.Default.Friday && dateOfWeek.Equals("Friday"))
                return true;
            return false;
        }
        private void nudSavePeriodicaly_ValueChanged(object sender, EventArgs e)
        {
            UpdateProperties();
            UpdateSettingLabel();
        }
        private void UpdateSettingLabel()
        {
            lblSettings.Text = String.Format("SS Program will story result under \n {0} \n every {1} minutes", 
                                                Properties.Settings.Default.destinationPath, 
                                                Properties.Settings.Default.savePeriodical);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            switch (btnStart.Text)
            {
                case "Start":
                    this.ssThread = new Thread(() => TStart());
                    this.ssThread.Start();
                    btnStart.Text = "Stop";
                    break;
                case "Stop":
                    this.ssThread.Abort();
                    btnStart.Text = "Start";
                    break;
            }
        }
        private void TStart()
        {
            ScreenSaver ss = new ScreenSaver();
            ss.StartProcess();
        }
        private void OnApplicationExit(object sender, EventArgs e)
        {
            if (ssThread.ThreadState.HasFlag(System.Threading.ThreadState.SuspendRequested) 
                || ssThread.ThreadState.HasFlag(System.Threading.ThreadState.Suspended))
            {
                ssThread.Resume();
            }
            if (ssThread.IsAlive)
            {
                this.ssThread.Abort();
                this.ssThread.Join();
            }
            
        }

        private void dpStartDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateProperties();
        }

        private void dpEndDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateProperties();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            e.Cancel = true;
        }

        private void closeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
