using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMirror.Model
{
    public sealed class Settings
    {
        public static Settings instance = null;
        public static readonly object padlock = new object();
        public String city { get; set; }
        public List<String> stocks { get; set; }

        private Settings() { }
        public static Settings Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Settings();

                    }
                    return instance;
                }
            }
        }
    }
}
