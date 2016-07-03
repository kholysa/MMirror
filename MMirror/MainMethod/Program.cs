using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using MMirror.Controller;
using MMirror.Model;
using MMirror.View;
using Newtonsoft.Json.Linq;
using System.IO;
using Raspberry.IO.GeneralPurpose;

namespace MMirror
{
    static class Program
    {
        static int edges =0;
        static stockView stockView;
        static Form1 weatherView;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MMirrorManager mm = MMirrorManager.Instance;
            //incase our downloaded data isnt complete, we just get what we last stored
            try
            {
                dynamic manager = JObject.Parse(File.ReadAllText(@"../../Data/tempArray.json"));

                List<stocks> stock;
                stock = manager.stock.ToObject<List<stocks>>();

                List<weatherDay> weather;
                weather = manager.weather.ToObject<List<weatherDay>>();

                mm.setStock(stock);
                mm.setWeather(weather);
            }
            catch (Exception)
            {
            }
            
            weatherController wc = new weatherController(mm);
            wc.getWeatherJSON();
           
            stockInfo si = new stockInfo();
            si.getStockFile();
  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            stockView = new stockView();
            Application.Run(stockView);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            weatherView = new Form1();
            Application.Run(weatherView);
            weatherView.Visible = false;
           

            InputPinConfiguration p = new InputPinConfiguration(ConnectorPin.P1Pin07.ToProcessor());
            GpioConnection g = new GpioConnection (p);
            g.PinStatusChanged += g_detected;
  
        }
        static void g_detected(object sender,PinStatusEventArgs e)
        {
            edges++;
            switch(edges)
            {
                case 1:
                    break;
                case 2:
                    edges = 0;
                    if (weatherView.Visible)
                    {
                        weatherView.Visible = false;
                        stockView.Visible = true;
                    }
                    else if (!weatherView.Visible)
                    {
                        weatherView.Visible = true;
                        stockView.Visible = false;
                    }
                    break;
            }
        }

        
    }
}
