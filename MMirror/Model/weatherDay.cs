using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMirror.Model
{
    class weatherDay
    {
        public double hi { get; set; }
        double lo { get; set; }
        int[] eightHourForcast = new int[8]; 
        String day { get; set; }
        enum MyEnum
        {
            clearSky, fewClouds, scatteredClouds,
            brokenClouds, showerRain, rain,
            thunderstorms, snow, mist
        };
        double rain { get; set; }
        double snow { get; set; }
        int feelsLike { get; set; }
    }
}
