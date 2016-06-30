﻿using System;
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
            string[] times = new string[4];
            int[] timesInt = new int[4];
            for (int i = 0; i < times.Length; i++)
            {
                if (mmc.getWeather()[0].twelveHourTimes[i] > 12)
                {
                    timesInt[i] = mmc.getWeather()[0].twelveHourTimes[i] - 12;
                    times[i] = Convert.ToString(timesInt[i]) + "p";
                }
                if (mmc.getWeather()[0].twelveHourTimes[i] == 12)
                {
                    timesInt[i] = mmc.getWeather()[0].twelveHourTimes[i];
                    times[i] = Convert.ToString(timesInt[i]) + "p";
                }
                else
                {
                    timesInt[i] = mmc.getWeather()[0].twelveHourTimes[i];
                    times[i] = Convert.ToString(timesInt[i]) + "a";
                }
            }
            currentTime1.Text = Convert.ToString(times[0]) ;
            currentTime2.Text = Convert.ToString(times[1]) ;
            currentTime3.Text = Convert.ToString(times[2]) ;
            currentTime4.Text = Convert.ToString(times[3]) ;

            //the image of the humidity
            Image humidity = Image.FromFile(@"..\..\Data\humidity.png");
            currentHumidityIMG.Size = new Size(humidity.Width, humidity.Height);
            currentHumidityIMG.Image = humidity;

            //humidity
            currentHumidity.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[0].humidity)+"%");
            currentLocation.Text = "Current weather";
            location.Text = mmc.getWeather()[0].location;
            forecastWeather.Text = "Weather Forecast";
            
            //image of current weather
            Image img = Image.FromFile(@"..\..\Data\" + mmc.getWeather()[0].weatherConditions+".png");
            currentImage.Size = new Size(img.Width, img.Height);
            currentImage.Image = img;

            //only display this data if we recieve it
            if (mmc.getWeather()[0].rain == -50)
            {
                currentRain.Text = "";
            }
            else
            {
                Image rain = Image.FromFile(@"..\..\Data\rain.png");
                rainIMG.Size = new Size(50,50);
                rainIMG.Image = img;
                currentRain.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[0].rain) + "cm");
         
            }
            if (mmc.getWeather()[0].snow == -50)
            {
                currentSnow.Text = "";
            }
            else
            {
                Image snow = Image.FromFile(@"..\..\Data\snow.png");
                snowIMG.Size = new Size(50, 50);
                snowIMG.Image = img;
                
                currentSnow.Text = Convert.ToString(Convert.ToInt32(mmc.getWeather()[0].snow) + "cm");
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
            //the days of the weather forecast
            DateTime dt = DateTime.Now;
            Tomorrow.Text = Convert.ToString(dt.AddDays(1).DayOfWeek);
            tomorrow2.Text = Convert.ToString(dt.AddDays(2).DayOfWeek);
            tomorrow3.Text = Convert.ToString(dt.AddDays(3).DayOfWeek);
            tomorrow4.Text = Convert.ToString(dt.AddDays(4).DayOfWeek);
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
