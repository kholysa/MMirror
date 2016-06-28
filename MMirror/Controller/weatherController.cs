using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;


namespace MMirror.Controller
{
    class weatherController
    {
        String url = "http://api.openweathermap.org/data/2.5/forecast/city?id=285570&APPID=1f780e08485942a7b677fb6e9a064233";
        String cityCode = "285570";//kuwait's code for openweathermap
        String API = "&APPID=30b0e4a13dcb98a91143652520f8f108"; //my personal api

        public weatherController() { }

        public void getWeatherJSON()
        {  
            //the next three lines download and save the weather data for the given city
            WebClient n = new WebClient();
            String jsData = n.DownloadString(url);
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", "jsWeatherData.json"), jsData);
            //now we will have to create c# weatherDay classes with the selected attributes
        }
      
        
    }
}
