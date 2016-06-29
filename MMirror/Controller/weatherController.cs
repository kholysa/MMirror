﻿using System;
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
        String urlCurrent = "http://api.openweathermap.org/data/2.5/weather?id=6077243&appid=30b0e4a13dcb98a91143652520f8f108";
        //urlForecast gives future data in a long ass list
        String urlForecast = "http://api.openweathermap.org/data/2.5/forecast?id=6077243&appid=30b0e4a13dcb98a91143652520f8f108";

        String cityCode = "6077243";//Montreal's code for openweathermap
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
            jsData = jsData.Replace("3h", "h");
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", "jsWeatherDataCurrent.json"), jsData);
            
            jsData = n.DownloadString(urlForecast);
            jsData = jsData.Replace("3h", "h");
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", "jsWeatherDataForecast.json"), jsData);
            


            //now we will have to create c# weatherDay classes with the selected attributes
            createCurrentJSONObject();
        }
        private void createCurrentJSONObject()
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

            //we will get the forecast data from the second URL
            dynamic weatherForecast = JObject.Parse(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", "jsWeatherDataForecast.json")));
            int[] twelveHourForecast = new int[4];
            for (int i = 0; i < twelveHourForecast.Length; i++)
            {
                twelveHourForecast[i] = weatherForecast.list[i].main.temp;
            }

       

            //not every API reply will have a rain parameter
            try{

                current.rain = weatherForecast.list[1].rain.h;
            }
            catch (Exception){ }
             try{
                current.snow = weatherForecast.list[1].snow.h;
            }
            catch (Exception){ }
            
            current.description = weatherCurrent.weather[0].description;
            current.twelveHourForcast = twelveHourForecast;
            //placing the current weather in the mmc 
            mmc.setWeather(0, current);
            createForecastJSONObject();
        }
        public void createForecastJSONObject()
        {
            //dear god bear with me here
            //we get the next 40 data sets
            //we will create a 4 day forecast with avgHi and avgLo temperatures
            //initially, we will get the 32 data sets beginning at 12 midnight (tomorrow/tonight) i.e, we will have the 4 comprehensive day data set
            //this will be saved in fourDayList

            dynamic weatherForecast = JObject.Parse(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", "jsWeatherDataForecast.json")));
            int count = 0;
            weatherDay[] fourDaylist = new weatherDay[32];
            int listCount = 0;
            for (count = 0; count < 40; count++)
            {
                DateTime dtToday = DateTime.Now.Date;
                DateTime dtForecast = Convert.ToDateTime(weatherForecast.list[count].dt_txt).Date;
                if (dtToday == dtForecast)
                {
                    break;
                }
            }
            for (listCount = 0; listCount < 32; listCount++)
            {
                weatherDay temp = new weatherDay();
                temp.hi = weatherForecast.list[count].main.temp_max;
                temp.lo = weatherForecast.list[count].main.temp_min;
                temp.day = Convert.ToString(Convert.ToDateTime(weatherForecast.list[count].dt_txt).DayOfWeek);
                temp.humidity = weatherForecast.list[count].main.humidity;
                temp.location = weatherForecast.city.name;
                fourDaylist[listCount] = temp;
            }
            listCount = 0;
            weatherDay[] fourDayForecast = new weatherDay[4];
            //then, we will get the avg of each 8 data sets in the fourDayList
            //this will give us the avg numbers we want in each day
            //these averages will be stored in the fourDayForecast array
            //we will then add these to the MirrorManager
            //and...i think thats it for the weather controller :O
            double avgHi = 0;
            double avgLo = 0;
            string day = "";
            int avgHumidity = 0;
            string location = "";           
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    
                   
                    avgHi = avgHi + fourDaylist[listCount].hi;
                    avgLo = avgLo + fourDaylist[listCount].lo;
                    day = fourDaylist[listCount].day;
                    avgHumidity = avgHumidity + fourDaylist[listCount].humidity;
                    location = fourDaylist[listCount].location;
                   
                    listCount++;
                }
                avgHi = avgHi / 8;
                avgLo = avgLo / 8;
                avgHumidity = avgHumidity / 8;
                
                weatherDay temp = new weatherDay();
                temp.hi=avgHi;
                temp.lo=avgLo;
                temp.humidity = avgHumidity;
                temp.day = day;
                temp.location = location;

                fourDayForecast[i] = temp;

            }
            // printing debugger :D   
            // string json = Newtonsoft.Json.JsonConvert.SerializeObject(fourDayForecast);
            // File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", "tempArray.json"), json);
            for (int i = 1; i < 5; i++)
            {
                mmc.setWeather(i, fourDayForecast[i - 1]);
            }
            // printing debugger :D   
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(this.mmc);
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", "tempArray.json"), json);
            

        }
      
        
    }
}