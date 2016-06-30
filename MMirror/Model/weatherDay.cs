using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMirror.Model
{
    public class weatherDay
    {
        public string location { get; set; } 
        public double hi { get; set; }
        public double lo { get; set; }
        public int[] twelveHourForcast = new int[4];
        public int[] twelveHourTimes = new int[4];
        public String day { get; set; }
   
        public double rain { get; set; } // no code dealing with this yet
        public double snow { get; set; } // same here
        public string description { get; set; }
        public string weatherConditions { get; set; }
        public int feelsLike { get; set; } //not supported, not used
        public int humidity { get; set; }
        public weatherDay()
        {
            this.rain = -50;
            this.snow = -50;
        }
        
        public string toString()
        {
            return location + "\n" + Convert.ToString(Convert.ToInt32(hi-273.15))+"\n" + Convert.ToString(Convert.ToInt32(lo-273.15)) + "\n" + Convert.ToString(twelveHourForcast) + "\n" + day +"\n"+ Convert.ToString(humidity)+"%";
        }
    }
    public enum weatherPattern
    {
        clearSky, fewClouds, scatteredClouds,
        brokenClouds, showerRain, rain,
        thunderstorms, snow, mist
    }
    
}
