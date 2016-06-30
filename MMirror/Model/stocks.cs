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
        public int closePrice { get; set; }
        public int volume { get; set; }
        public int avgVolume { get; set; }
        public int volatility { get; set; }
        public stocks() 
        {
        }

        
    }
}
