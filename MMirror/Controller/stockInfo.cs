using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace MMirror.Controller
{
    class stockInfo
    {
        public stockInfo(){}
        public void getStockFile()
        {
            //download the csv file and save it in the DATA folder
            String URL = "http://download.finance.yahoo.com/d/quotes.csv?s=YHOO+GOOG+MSFT+AAPL&f=spva2a";
            WebClient n = new WebClient();
            //dleete the old file
            File.Delete(@"..\..\Data\stockInfo.txt");
            n.DownloadFile(URL, "stockInfo.txt");
            //place the new stockInfo in the data folder
            File.Move("stockInfo.txt", @"..\..\Data\stockInfo.txt");


            readStockInfo();
        }
        public void readStockInfo()
        {
            string line = File.ReadAllText(@"..\..\Data\stockInfo.txt");
            var reader = new StreamReader(File.OpenRead(@"..\..\Data\stockInfo.txt"));
            string[,] listA = new string[3,5];
            string debugger = "";
            
           // var line = reader.ReadToEnd();
          //  var values = line.Split(',');

            
                   
           /* for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    
                 //   listA[i, j] = values[j];
                    debugger += "" + listA[i, j] + ",";
                }
                debugger += "\n";
            }
            listA   = File.ReadLines(@"..\..\Data\stockInfo.txt").Select(s => s.Split(',')).ToArray();
            String input = File.ReadAllText(@"..\..\Data\stockInfo.txt");

            int i = 0, j = 0;
            string[,] result = new string[3, 5];
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(','))
                {
                    result[i, j] = string.Parse(col.Trim());
                    j++;
                }
                i++;
            }

            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", "tempArray.json"), result[0,1]);


            // printing debugger :D   
            //string json = Newtonsoft.Json.JsonConvert.SerializeObject(this.mmc);
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\", "tempArray.json"), debugger);
            while (!reader.EndOfStream)
            {
                int counter = 0;
                var line = reader.ReadLine();
                string[] values = line.Split(',');
                while (counter < 5)
                {
                    ListA[counter] = values[counter];
                }


            }*/

        }
    }
}
