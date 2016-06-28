using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMirror.Model
{
    class MMirrorManager
    {
        List<weatherDay> weather { get; set; }
        List<sports> sport { get; set; }
        bool isInitialised = false;
        public MMirrorManager()
        {
            //store that we did create this upon startup 
            isInitialised = true;
            //filling the list with a blank weatherDay to allow for modification in the 5 day forcast
            weather = new List<weatherDay>(5);
            for (int i = 0; i < 5; i++)
            {
                weather.Add(new weatherDay());
            }
            //
            sport = new List<sports>(1);
            sport.Add(new sports());
        }
 /*       public void modifyWeather(int day, weatherDay newWeather){
            weather.RemoveAt(day);
            weather.Insert(day, newWeather);
        }
        public void modifySport(sports newSport)
        {
            sport.RemoveAt(0);
            sport.Add(newSport);
        }*/
    }
}
