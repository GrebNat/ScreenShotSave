using System;
using System.Threading;

namespace SS
{
    class SaveThread
    {
        public Thread ssThread;
        MainForm form;
        ScreenSaver ss;

        public SaveThread(MainForm form)
        {
            this.form = form;
        }
        public void Start()
        {

            this.ssThread = new Thread(() => TStart());
            this.ssThread.Start();
        }

        public void Abort()
        {
            this.ssThread.Abort();
        }

        public void Kill()
        {
            if (ssThread.ThreadState.HasFlag(ThreadState.SuspendRequested)
                || ssThread.ThreadState.HasFlag(ThreadState.Suspended))
            {
                ssThread.Resume();
            }
            if (ssThread.IsAlive)
            {
                this.ssThread.Abort();
                this.ssThread.Join();
            }
        }

        private void TStart()
        {
            ss = new ScreenSaver();
            StartProcess();
        }

        public void Resume()
        {
            if (ssThread.ThreadState.Equals(System.Threading.ThreadState.Suspended) ||
                    ssThread.ThreadState.Equals(System.Threading.ThreadState.SuspendRequested))
            {
                try
                {
                    ssThread.Resume();
                    form.setSuccessfull();
                    form.setFail();
                }
                catch
                {
                    form.setFail();
                }
            }
        }
        public void Suspend()
        {
            if (!ssThread.ThreadState.Equals(ThreadState.Suspended))
            {
                ssThread.Suspend();
                form.pbSavedPicture.BackgroundImage = null;
                form.setFail();
            }
        }

        public void StartProcess()
        {
            while (ss.SavePicture())
            {
                form.pbSavedPicture.BackgroundImage = new System.Drawing.Bitmap(ss.LastSavedFileName);
                form.setSuccessfull();
                Thread.Sleep(TimeSpan.FromMinutes(Properties.Settings.Default.savePeriodical));
            }
        }
    }
}
