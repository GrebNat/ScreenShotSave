using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SS
{
    public partial class MainForm : Form
    {
        Timer timer = new Timer();

        SaveThread ssTread;
        public MainForm()
        {
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            timer.Interval = 1000;
            timer.Start();
            timer.Tick += new EventHandler(SystemEvents_TimeChanged);

            LoadProperties();
            UpdateSettingLabel();
            ssTread = new SaveThread(this);
            ssTread.Start();
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
          //  label1.Text = currentTime.ToString() +" "+ ssTread.ssThread.ThreadState.ToString();

            if (currentTime >= Properties.Settings.Default.startTime
                && currentTime <= Properties.Settings.Default.endTime
                && CorrectDayOfWeek())
            {
                ssTread.Resume();
            }
            else
            {
                ssTread.Suspend();
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

        private void LoadProperties()
        {

            bool localMonday = Properties.Settings.Default.Monday;
            bool localTuesday = Properties.Settings.Default.Tuesday;
            bool localWednesday = Properties.Settings.Default.Wednesday;
            bool localFriday = Properties.Settings.Default.Friday;
            bool localThursday = Properties.Settings.Default.Thursday;
            bool localSaturday = Properties.Settings.Default.Sunday;
            bool localSunday = Properties.Settings.Default.Sunday;

            int localSavePeriodically = Properties.Settings.Default.savePeriodical;
            string localDestinationPath = Properties.Settings.Default.destinationPath;


            cbMonday.CheckState = localMonday ? CheckState.Checked: CheckState.Unchecked;
            cbTuesday.CheckState = localTuesday ? CheckState.Checked : CheckState.Unchecked;
            cbWednesday.CheckState = localWednesday ? CheckState.Checked : CheckState.Unchecked;
            cbThursday.CheckState = localThursday ? CheckState.Checked : CheckState.Unchecked;
            cbFriday.CheckState = localFriday ? CheckState.Checked : CheckState.Unchecked;
            cbSaturday.CheckState = localSaturday ? CheckState.Checked : CheckState.Unchecked;
            cbSunday.CheckState = localSunday ? CheckState.Checked : CheckState.Unchecked;

            
            nudSavePeriodicaly.Value = localSavePeriodically;
            tfDestinationFolder.Text = localDestinationPath;
        //    dpStartDate. = Properties.Settings.Default.startTime;
        //    dpEndDate.Value = Properties.Settings.Default.endTime;

        }
        public void UpdateProperties()
        {

            Properties.Settings.Default.savePeriodical = (int)nudSavePeriodicaly.Value;
            Properties.Settings.Default.destinationPath = tfDestinationFolder.Text;

            Properties.Settings.Default.startTime = dpStartDate.Value.TimeOfDay;
            Properties.Settings.Default.endTime = dpEndDate.Value.TimeOfDay;

            Properties.Settings.Default.Monday = (cbMonday.CheckState == CheckState.Checked) ? true : false;
            Properties.Settings.Default.Tuesday = (cbTuesday.CheckState == CheckState.Checked) ? true : false;
            Properties.Settings.Default.Wednesday = (cbWednesday.CheckState == CheckState.Checked) ? true : false;
            Properties.Settings.Default.Thursday = (cbThursday.CheckState == CheckState.Checked) ? true : false;
            Properties.Settings.Default.Friday = (cbFriday.CheckState == CheckState.Checked) ? true : false;
            Properties.Settings.Default.Saturday = (cbSaturday.CheckState == CheckState.Checked) ? true : false;
            Properties.Settings.Default.Sunday = (cbSunday.CheckState == CheckState.Checked) ? true : false;

            Properties.Settings.Default.Save();
        }

        public bool CorrectDayOfWeek()
        {
            string dateOfWeek = DateTime.Now.DayOfWeek.ToString();
            if ((Properties.Settings.Default.Monday && dateOfWeek.Equals("Monday"))
                || (Properties.Settings.Default.Thursday && dateOfWeek.Equals("Thursday"))
                || (Properties.Settings.Default.Wednesday && dateOfWeek.Equals("Wednesday"))
                || (Properties.Settings.Default.Tuesday && dateOfWeek.Equals("Tuesday"))
                || (Properties.Settings.Default.Friday && dateOfWeek.Equals("Friday"))
                || (Properties.Settings.Default.Saturday && dateOfWeek.Equals("Saturday"))
                || (Properties.Settings.Default.Sunday && dateOfWeek.Equals("Sunday")))
                return true;
            else
                return false;
        }
        private void nudSavePeriodicaly_ValueChanged(object sender, EventArgs e)
        {
            UpdateProperties();
            UpdateSettingLabel();
        }
        private void UpdateSettingLabel()
        {
            this.Text = String.Format("SAVE SCREEN PICTURE will store result every {1} minutes under \n {0} \n ",
                                                Properties.Settings.Default.destinationPath,
                                                Properties.Settings.Default.savePeriodical);
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            ssTread.Kill();
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

        private void cbWeekDay_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProperties();
        }

        public void setSuccessfull()
        {
            pbStatus.Image = new Bitmap(@"D:\c#-projects\SS\green2.png");
            this.lblStatus.ForeColor = Color.Green;
        }

        public void setFail()
        {
            pbStatus.Image = new Bitmap(@"D:\c#-projects\SS\red.png");
            lblStatus.ForeColor = Color.Red;
        }
    }
}
