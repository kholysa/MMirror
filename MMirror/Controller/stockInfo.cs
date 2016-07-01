using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using MMirror.Model;

namespace MMirror.Controller
{
    class stockInfo
    {
        public stockInfo(){}
        public void getStockFile()
        {
            //download the csv file and save it in the DATA folder
            //s = symbol
            //p = previous close
            //v = volume
            //a2 = avg daily volume
            //c = change and percent change
            String URL = "http://download.finance.yahoo.com/d/quotes.csv?s=YHOO+GOOG+MSFT+AAPL&f=spva2c";
            WebClient n = new WebClient();
            //dleete the old file
            File.Delete(@"..\..\Data\stockInfo.csv");
            n.DownloadFile(URL, "stockInfo.csv");
            //place the new stockInfo in the data folder
            File.Move("stockInfo.csv", @"../../Data/stockInfo.csv");


            readStockInfo();
        }
        public void readStockInfo()
        {
            string input = File.ReadAllText(@"../../Data/stockInfo.csv");
            
           // var reader = new StreamReader(File.OpenRead(@"..\..\Data\stockInfo.txt"));
           // string[,] listA = new string[3,5];
          //  string debugger = "";
            int i = 0, j = 0;
            string[,] result = new string[5, 5];
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(','))
                {
                    result[i, j] = col.Trim();
                    j++;
                }
                i++;
            }
            MMirrorManager mmc = MMirrorManager.instance;
            for (i = 0; i < result.GetLength(0)-1; i++)
            {
                
                stocks temp = new stocks();
                temp.stockName = result[i, 0];
                if (result[i, 1] == "N/A")
                {
                    temp.closePrice = mmc.getStock(i).closePrice;
                }
                temp.closePrice = Convert.ToDouble(result[i, 1]);
                if (result[i, 2] == "N/A")
                {
                    temp.volume = mmc.getStock(i).volume;
                }
                temp.volume = Convert.ToDouble(result[i, 2]);

                if (result[i, 1] == "N/A")
                {
                    temp.avgVolume = mmc.getStock(i).avgVolume;
                }
                temp.avgVolume = Convert.ToDouble(result[i, 3]);

                if (result[i, 1] == "N/A")
                {
                    temp.volatility = mmc.getStock(i).volatility;
                }
                temp.volatility = result[i, 4];
                
                mmc.setStock(i, temp);
                
            }

            // printing debugger :D   
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(mmc);
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"../../Data/", "tempArray.json"), json);
                

    

        }
    }
}
