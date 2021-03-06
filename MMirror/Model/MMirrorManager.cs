﻿using System;
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
        public List<weatherDay> weather = new List<weatherDay> { null, null, null,null,null };
        public sports sport = new sports();
        public stocks[] stock = new stocks[6];

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
            this.weather[i] = weatherInput;
        }
        public stocks[] getStocks()
        {
            return this.stock;
        }
        public stocks getStock(int i)
        {
            return stock[i];
        }
        public void setStock(stocks[] input)
        {
            this.stock = input;
        }
        public void setStock(int i, stocks stockInput)
        {
            this.stock[i] = stockInput;
        }
    }


}
