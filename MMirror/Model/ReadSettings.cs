using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
namespace MMirror.Model
{
    class ReadSettings
    {
        String city;
        List<String> stocks;
        MMirrorManager sett;
        public ReadSettings()
        {
            /*TODO:
             *COPY FILE FROM DEFAULT DOWNLOAD TO DATA FOLDER AS HTML 
             */
            //read the string we sent from the phone
            string json = File.ReadAllText(@"../../Data/Settings.json");
            
            //remove the html tags (hopefully they never change)
   
            String result = Regex.Replace(json, @"<[^>]*>", String.Empty);
           
            
            //create object from json text
            dynamic clss = JObject.Parse(result);
            Settings sett = Settings.Instance;

            sett.city = clss.city;
            sett.stocks = clss.stocks.ToObject<List<String>>();

        
        }
    }
   
}
