using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS
{
    class ScreenSaver
    {

        public void StartProcess() {
            while (SavePicture())
            {
                Thread.Sleep(TimeSpan.FromMinutes(Properties.Settings.Default.savePeriodical));
            }
        }
        public Bitmap TakeScreenShot()
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppRgb);
            Graphics gr = Graphics.FromImage(bmp);

            gr.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);

            return bmp;
        }

        public bool SavePicture()
        {
           
            string dirName = Properties.Settings.Default.destinationPath + "/" + generateFolderName();
            string fileName = dirName + "/" + generatePictureName();
            FileStream file = null;

            Bitmap btm = TakeScreenShot();

            if (!Directory.Exists(dirName))
            {
                Directory.CreateDirectory(dirName);
            }
     
            try
            { 
                file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                btm.Save(file, ImageFormat.Jpeg);
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                file.Close();
            }

        }
        private string generatePictureName()
        {
            return DateTime.Now.ToString("HH-mm-ss");
           
        }
        private string generateFolderName()
        {
            return DateTime.Now.ToString("dd-MM-yyyy");
        }
    }
}
