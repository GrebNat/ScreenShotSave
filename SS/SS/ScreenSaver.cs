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
            int screenLeft = SystemInformation.VirtualScreen.Left,
                screenTop = SystemInformation.VirtualScreen.Top,
                screenWidth = SystemInformation.VirtualScreen.Width,
                screenHeight = SystemInformation.VirtualScreen.Height;
            
            Bitmap bmp = new Bitmap(screenWidth, screenHeight);
            Graphics.FromImage(bmp).CopyFromScreen(screenLeft, screenTop, 0, 0, bmp.Size);

            return bmp;
            
        }

        public bool SavePicture()
        {
           
            string dirName = Properties.Settings.Default.destinationPath + "/" + generateFolderName();
            string fileName = String.Format("{0}/{1}.{2}", dirName, generatePictureName(), ImageFormat.Jpeg);
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
