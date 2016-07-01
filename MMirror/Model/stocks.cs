using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMirror.Model
{
    public class stocks
    {   
        public string stockName { get; set; }
        public double closePrice { get; set; }
        public double volume { get; set; }
        public double avgVolume { get; set; }
        public string volatility { get; set; }
        public stocks() 
        {
        }

        
    }
}
