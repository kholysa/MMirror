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
            File.Delete(@"..\..\Data\stockInfo.csv");
            n.DownloadFile(URL, "stockInfo.csv");
            //place the new stockInfo in the data folder
            File.Move("stockInfo.csv", @"..\..\Data\stockInfo.csv");
        }

    }
}
