using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MMirror.Model;
using MMirror.Controller;

namespace MMirror
{
   
    public partial class Form1 : Form
    {
       // public MMirrorManager mmc { get; set; }
        public Form1()
        {

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MMirrorManager mmc = MMirrorManager.Instance;

            currentWeather.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[0].hi - 273.15) + "°C");
            
            currentForecast1.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[0].twelveHourForcast[0] - 273.15) + "°C");
            currentForecast2.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[0].twelveHourForcast[1] - 273.15) + "°C");
            currentForecast3.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[0].twelveHourForcast[2] - 273.15) + "°C");
            currentForecast4.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[0].twelveHourForcast[3] - 273.15) + "°C");

            currentTime1.Text = Convert.ToString(mmc.getWeather()[0].twelveHourTimes[0]) + "h";
            currentTime2.Text = Convert.ToString(mmc.getWeather()[0].twelveHourTimes[1]) + "h";
            currentTime3.Text = Convert.ToString(mmc.getWeather()[0].twelveHourTimes[2]) + "h";
            currentTime4.Text = Convert.ToString(mmc.getWeather()[0].twelveHourTimes[3]) + "h";

            Image humidity = Image.FromFile(@"..\..\Data\humidity.png");
            currentHumidityIMG.Size = new Size(humidity.Width, humidity.Height);
            currentHumidityIMG.Image = humidity;

            currentHumidity.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[0].humidity)+"%");
            currentLocation.Text = "Current weather";
            location.Text = mmc.getWeather()[0].location;
            forecastWeather.Text = "Forecasted weather";
            
            Image i = Image.FromFile(@"..\..\Data\" + mmc.getWeather()[0].weatherConditions+".png");
            currentImage.Size = new Size(i.Width, i.Height);
            currentImage.Image = i;


            if (mmc.getWeather()[0].rain == -50)
            {
                currentRain.Text = "";
            }
            else
            {
                currentRain.Text = "Rain: "+Convert.ToString(Convert.ToInt32(mmc.getWeather()[0].rain) + "mm");
            }
            if (mmc.getWeather()[0].snow == -50)
            {
                currentSnow.Text = "";
            }
            else
            {
                currentRain.Text = "Snowfall: " +Convert.ToString(Convert.ToInt32(mmc.getWeather()[0].snow) + "cm");
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void forecastWeather_Click(object sender, EventArgs e)
        {

        }
    }
}
