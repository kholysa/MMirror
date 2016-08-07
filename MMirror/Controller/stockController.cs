using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using MMirror.Model;
using System.ComponentModel;

namespace MMirror.Controller
{
    class stockController
    {
        public dynamic er;
        string data;
        public stockController(){}
        public void getStockFile()
        {
            ReadSettings rs = new ReadSettings();
           
            //download the csv file and save it in the DATA folder
            //s = symbol
            //p = previous close
            //v = volume
            //a2 = avg daily volume
            //c = change and percent change
            Settings smo = Settings.instance;
            List<String> stockList = smo.stocks;
            String URL = "http://download.finance.yahoo.com/d/quotes.csv?s=YHOO+GOOG+MSFT+TSLA&f=spva2c";
            String URLModular = "http://download.finance.yahoo.com/d/quotes.csv?s=";
            String attributes = "&f=spva2c";
 
            for (int i = 0; i < stockList.Count; i++)
            {
                URLModular = URLModular + "+" + stockList[i];
            }
            URLModular = URLModular + attributes;
            WebClient n = new WebClient();
            n.DownloadStringCompleted+=new DownloadStringCompletedEventHandler(getNData);
            //dleete the old file
            try
            {
                n.DownloadStringAsync(new Uri(URLModular), data);
            }
            catch (Exception e)
            {
                throw e;
            }
            //place the new stockInfo in the data folder
            


        }
        private void getNData(Object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                data = e.Result;
                File.WriteAllText(@"../../Data/stockInfo.csv", data);
                readStockInfo();
            }
            catch (Exception e1)
            {
                this.er = e1;
            }
        }
        public void readStockInfo()
        {
            Settings smo = Settings.instance;
            List<String> stockList = smo.stocks;
            string input = data;
            //string input = File.ReadAllText(@"../../Data/stockInfo.csv");
            
            int i = 0, j = 0;
            string[,] result = new string[stockList.Count, 5];
            try
            {
                foreach (var row in input.Split('\n'))
                {
                    j = 0;
                    foreach (var col in row.Trim().Split(','))
                    {
                        result[i, j] = col.Trim();
                        j++;
                    }
                    i++;
                    if (i == stockList.Count)
                        break;
                }
            }
            catch (NullReferenceException)
            {
                return;
            }
            MMirrorManager mmc = MMirrorManager.instance;
           
            //creating temp stock instance, populate with data from array
            //watch out for N/A

          

            for (i = 0; i < stockList.Count; i++)
            {
                
                stocks temp = new stocks();
                temp.stockName = result[i, 0];
                if (result[i, 1] == "N/A")
                {
                    temp.closePrice = mmc.getStock(i).closePrice;
                }else
                    temp.closePrice = Convert.ToDouble(result[i, 1]);
                
                if (result[i, 2] == "N/A")
                {
                    temp.volume = mmc.getStock(i).volume;
                }else
                    temp.volume = Convert.ToDouble(result[i, 2]);

                if (result[i, 1] == "N/A")
                {
                    temp.avgVolume = mmc.getStock(i).avgVolume;
                }else
                    temp.avgVolume = Convert.ToDouble(result[i, 3]);

                if (result[i, 1] == "N/A")
                {
                    temp.volatility = mmc.getStock(i).volatility;
                }
                else
                {
                    result[i, 4] = result[i, 4].Replace(" -", " ,");
                    result[i, 4] = result[i, 4].Replace(" , ,", " , -");
                    result[i, 4] = result[i, 4].Replace("\"", "");


                    temp.volatility = result[i, 4];
                }
                mmc.setStock(i, temp);
             
          }

            // printing debugger :D   
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(mmc);
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"../../Data/", "tempArray.json"), json);
           
    

        }
    }
}
