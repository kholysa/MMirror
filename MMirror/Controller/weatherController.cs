using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using MMirror.Model;



namespace MMirror.Controller
{
    class weatherController
    {
        //urlCurrent gives current data gives 
        String urlCurrent = "http://api.openweathermap.org/data/2.5/weather?id=285570&appid=30b0e4a13dcb98a91143652520f8f108";
        //urlForecast gives future data in a long ass list
        String urlForecast = "http://api.openweathermap.org/data/2.5/forecast?id=285570&appid=30b0e4a13dcb98a91143652520f8f108";

        String cityCode = "285570";//kuwait's code for openweathermap
        String API = "&APPID=30b0e4a13dcb98a91143652520f8f108"; //my personal api

        MMirrorManager mmc;

        public weatherController(MMirrorManager manager) {
            this.mmc = manager;
        }

        public void getWeatherJSON()
        {  
            //the next five lines download and save the weather data for the given city (first the current data
            //then the forecasted data)
            WebClient n = new WebClient();
            String jsData = n.DownloadString(urlCurrent);
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", "jsWeatherDataCurrent.json"), jsData);
            
            jsData = n.DownloadString(urlForecast);
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", "jsWeatherDataForecast.json"), jsData);
            
            //now we will have to create c# weatherDay classes with the selected attributes
            createJSONObject();
        }
        private void createJSONObject()
        {
            //this dynamic build an object whose attributes are decided on runtime (seems like a shady coding 
            //practice but idc c# is bae)
            dynamic weatherCurrent = JObject.Parse(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", "jsWeatherDataCurrent.json")));
            
            //here we create the "current weather information" and populate it from the jsWeatherDataCurrent.json
            weatherDay current = new weatherDay();
            current.hi = weatherCurrent.main.temp_max;
            current.lo = weatherCurrent.main.temp_min;
            current.day = DateTime.Now.DayOfWeek.ToString();
            current.humidity = weatherCurrent.main.humidity;
            current.location = weatherCurrent.name;

            dynamic weatherForecast = JObject.Parse(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", "jsWeatherDataForecast.json")));
            int[] twelveHourForecast = new int[4];
            for (int i = 0; i < twelveHourForecast.Length; i++)
            {
                twelveHourForecast[i] = weatherForecast.list[i].main.temp;
                
            }
            mmc.weather.Add(current);

        }

      
        
    }
}