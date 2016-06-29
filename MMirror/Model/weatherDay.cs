﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMirror.Model
{
    class weatherDay
    {
        public string location { get; set; } 
        public double hi { get; set; }
        public double lo { get; set; }
        public int[] twelveHourForcast = new int[4]; 
        public String day { get; set; }
        public enum MyEnum
        {
            clearSky, fewClouds, scatteredClouds,
            brokenClouds, showerRain, rain,
            thunderstorms, snow, mist
        };
        public double rain { get; set; } // no code dealing with this yet
        public double snow { get; set; }
        
        public int feelsLike { get; set; } //not supported, not used
        public int humidity { get; set; }
        
        
        public string toString()
        {
            return location + "" + hi.ToString() + lo.ToString() + "\n" + Convert.ToString(twelveHourForcast) + "\n" + day + Convert.ToString(humidity);
        }
    }
    
}