using System;
using System.IO;
using System.Timers;

namespace WindowsService
{
    class Sheduler
    {
        Timer oTimer = null;
        double interval = 20000;

        public void Start()
        {
            oTimer = new Timer(interval);
            oTimer.AutoReset = true;
            oTimer.Enabled = true;
            oTimer.Start();

            oTimer.Elapsed += new ElapsedEventHandler(oTimer_Elapsed);

        }

        private void oTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            FileCreation();
        }

        void FileCreation()
        {
            string sFilePath = @"C:\Users\leand\Desktop\file\ShedulerFile.txt";
            DateTime sDateTime = DateTime.Now;
            StreamWriter oFileWriter = new StreamWriter(sFilePath,true);
            oFileWriter.WriteLine($"\n {sDateTime}");
            oFileWriter.Close();

        }
    }
}
