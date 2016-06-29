using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMirror.Model
{
    public sealed class MMirrorManager
    {
        public static MMirrorManager instance = null;
        public static readonly object padlock = new object();
        public List<weatherDay> weather = new List<weatherDay>(5);
        public sports sport = new sports();

        private MMirrorManager() { }

        public static MMirrorManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new MMirrorManager();
                    }
                    return instance;
                }
            }
        }
        public sports getSports()
        {
            return sport;
        }

        public void setSports(sports sp)
        {
            this.sport = sp;
        }
        public List<weatherDay> getWeather()
        {
            return this.weather;
        }
        public void setWeather(List<weatherDay> input)
        {
            this.weather = input;
        }
        public void setWeather(int i, weatherDay weatherInput)
        {
            this.weather.Insert(i,weatherInput);
        }
    }

   /* class MMirrorManager
    {
        public List<weatherDay> weather = new List<weatherDay>(5); 
        public sports sport = new sports();
        bool isInitialised = false;
        static MMirrorManager()
        {
        }
        public MMirrorManager getInstance(){
            return this;
        }
       
        public sports getSports()
        {
            return sport;
        }

        public void setSports(sports sp){
            this.sport = sp;
        }
        public List<weatherDay> getWeather()
        {
            return this.weather;
        }
        public void setWeather(List<weatherDay> input)
        {
            this.weather = input;
        }
        public void setWeather(int i,weatherDay weatherInput)
        {
            this.weather[i] = weatherInput;
        }
            //store that we did create this upon startup 
          //  isInitialised = true;
            //filling the list with a blank weatherDay to allow for modification in the 5 day forcast
          //  weather = new List<weatherDay>(5);
     /*       for (int i = 0; i < 5; i++)
            {
                weather.Add(new weatherDay());
            }
            
           sport = new List<sports>(1);
           sport.Add(new sports());
        }
        public void modifyWeather(int day, weatherDay newWeather){
            weather.RemoveAt(day);
            weather.Insert(day, newWeather);
        }
        public void modifySport(sports newSport)
        {
            sport.RemoveAt(0);
            sport.Add(newSport);
        }
    }*/
}
