using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using MMirror.Controller;
using MMirror.Model;

namespace MMirror
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MMirrorManager mm = MMirrorManager.Instance;
            weatherController wc = new weatherController(mm);
            wc.getWeatherJSON();
           
            //stockInfo si = new stockInfo();
            //si.getStockFile();
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 windows = new Form1();
            Application.Run(windows);

        }
    }
}
