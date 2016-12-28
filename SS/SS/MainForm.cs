using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        Thread t;
        public MainForm()
        {
            InitializeComponent();
            notifyIcon1.Visible = false;
            this.notifyIcon1.MouseClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);

            // добавляем событие на изменение окна
            this.Resize += new System.EventHandler(this.Form1_Resize);

            UpdateProperties();
            UpdateSettingLabel();
            this.t = new Thread(() => TStart());
            this.t.Start();

            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            timer.Interval = 1000;
            timer.Tick += new EventHandler(SystemEvents_TimeChanged);
            timer.Start();
        
        }

        public void SystemEvents_TimeChanged(object sender, EventArgs e)
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            if (currentTime >= Properties.Settings.Default.startTime && currentTime <=Properties.Settings.Default.endTime)
            {
                label4.Text = "Tread state "+t.ThreadState;
                if (t.ThreadState.Equals(ThreadState.Suspended))
                {
                    try
                    {
                        t.Resume();
                        btnStart.Text = "Stop";
                    }
                    catch
                    {
                        label4.Text = t.IsAlive+" \n something happend, please restart";
                    }
                }
            }
            else
            {
                label4.Text = String.Format("Time changed: {0}", DateTime.Now);
                if (!t.ThreadState.Equals(ThreadState.Suspended))
                {
                    t.Suspend();
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
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
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
                    this.t = new Thread(() => TStart());
                    this.t.Start();
                    btnStart.Text = "Stop";
                    break;
                case "Stop":
                    this.t.Abort();
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
            if (t.IsAlive)
            {
                this.t.Abort();
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
    }
}
