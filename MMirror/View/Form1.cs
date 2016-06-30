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

            //lotta code, but im just populating the labels with the relevant data

            //current temp
            currentWeather.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[0].hi - 273.15) + "°C");
            
            //next tweleve hours
            currentForecast1.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[0].twelveHourForcast[0] - 273.15) + "°C");
            currentForecast2.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[0].twelveHourForcast[1] - 273.15) + "°C");
            currentForecast3.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[0].twelveHourForcast[2] - 273.15) + "°C");
            currentForecast4.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[0].twelveHourForcast[3] - 273.15) + "°C");

            //time of the forecast calculations
            currentTime1.Text = Convert.ToString(mmc.getWeather()[0].twelveHourTimes[0]) + "h";
            currentTime2.Text = Convert.ToString(mmc.getWeather()[0].twelveHourTimes[1]) + "h";
            currentTime3.Text = Convert.ToString(mmc.getWeather()[0].twelveHourTimes[2]) + "h";
            currentTime4.Text = Convert.ToString(mmc.getWeather()[0].twelveHourTimes[3]) + "h";

            //the image of the current weather
            Image humidity = Image.FromFile(@"..\..\Data\humidity.png");
            currentHumidityIMG.Size = new Size(humidity.Width, humidity.Height);
            currentHumidityIMG.Image = humidity;

            //humidity
            currentHumidity.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[0].humidity)+"%");
            currentLocation.Text = "Current weather";
            location.Text = mmc.getWeather()[0].location;
            forecastWeather.Text = "Forecasted weather";
            
            //image of current weather
            Image i = Image.FromFile(@"..\..\Data\" + mmc.getWeather()[0].weatherConditions+".png");
            currentImage.Size = new Size(i.Width, i.Height);
            currentImage.Image = i;

            //only display this data if we recieve it
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

            //the highs of the next few days
            forecastTemp1.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[1].hi - 273.15) + "°C");
            forecastTemp2.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[2].hi - 273.15) + "°C");
            forecastTemp3.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[3].hi - 273.15) + "°C");
            forecastTemp4.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[4].hi - 273.15) + "°C");
            //the los of the next 4 days
            forecastLo1.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[1].lo - 273.15) + "°C");
            forecastLo2.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[2].lo - 273.15) + "°C");
            forecastLo3.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[3].lo - 273.15) + "°C");
            forecastLo4.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[4].lo - 273.15) + "°C");
            //the image of the next few days
            forecastIMG1.Size = new System.Drawing.Size(50, 50);
            forecastIMG2.Size = new System.Drawing.Size(50, 50);
            forecastIMG3.Size = new System.Drawing.Size(50, 50);
            forecastIMG4.Size = new System.Drawing.Size(50, 50);

            forecastIMG1.Image = Image.FromFile(@"..\..\Data\" + mmc.getWeather()[1].weatherConditions + ".png");
            forecastIMG2.Image = Image.FromFile(@"..\..\Data\" + mmc.getWeather()[2].weatherConditions + ".png");
            forecastIMG3.Image = Image.FromFile(@"..\..\Data\" + mmc.getWeather()[3].weatherConditions + ".png");
            forecastIMG4.Image = Image.FromFile(@"..\..\Data\" + mmc.getWeather()[4].weatherConditions + ".png");
  
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

        private void forecastIMG1_Click(object sender, EventArgs e)
        {

        }

        private void forecastIMG2_Click(object sender, EventArgs e)
        {

        }

        private void forecastIMG3_Click(object sender, EventArgs e)
        {

        }

        private void forecastIMG4_Click(object sender, EventArgs e)
        {

        }
    }
}
