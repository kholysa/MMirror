using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Raspberry.IO.GeneralPurpose;

using System.Threading;
namespace MMirror.View
{
    public partial class DateAndTime : Form
    {
        int edges = 0;
        System.Windows.Forms.Timer tn;
        System.Windows.Forms.Timer t = null;
        System.Windows.Forms.Timer tnt;
        public DateAndTime()
        {
        
            
          
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            //let the labels update every minute
            //this is done by an event being raised every minute
            //the event modifies the labels

            tn = new System.Windows.Forms.Timer();
            tn.Interval = 1;
            tn.Tick += t_Tick_fade;

            InputPinConfiguration p = new InputPinConfiguration(ConnectorPin.P1Pin07.ToProcessor());
            GpioConnection g = new GpioConnection(p);
            g.PinStatusChanged += g_Detected;
            startFadeinTimer();
            StartTimer();
            this.Opacity = 0;
        }

        private void t_Tick_fade(object sender, EventArgs e)
        {
            if (this.Opacity < 0.01)
            {
               
                tn.Enabled = false;
                WeatherView wt = new WeatherView();
                wt.Show();
                wt.startFadeinTimer();
                this.Close();
                


            }

            this.Opacity -= 0.05;
        }
        public void startFadeinTimer()
        {
            tnt = new System.Windows.Forms.Timer();
            tnt.Interval = 1;
            tnt.Tick += tn_Tick;
            tnt.Enabled = true;
        }

        void tn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                tnt.Enabled = false;
            }
            this.Opacity += 0.1;
        }
        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;           
          
        }

        void t_Tick(object sender, EventArgs e)
        {
            //setting the hours format as 12 hour display
            if (DateTime.Now.Hour < 12 && DateTime.Now.Hour!=0)
            {
                lblHours.Text = DateTime.Now.Hour.ToString()+":";
                if (DateTime.Now.Minute.ToString().Length == 1)
                {
                    lblHours.Text += "0" + DateTime.Now.Minute.ToString();

                }
                else
                {
                    lblHours.Text += DateTime.Now.Minute.ToString();
                }
                    lblHours.Text+="AM";
            }
            else if (DateTime.Now.Hour == 0)
            {
                lblHours.Text = "12"  + ":";
                if (DateTime.Now.Minute.ToString().Length == 1)
                {
                    lblHours.Text += "0" + DateTime.Now.Minute.ToString();

                }
                else
                {
                    lblHours.Text += DateTime.Now.Minute.ToString();
                }
                lblHours.Text+="AM";
            }
            else if (DateTime.Now.Hour > 12)
            {
                lblHours.Text = (DateTime.Now.Hour - 12).ToString() + ":";
                if (DateTime.Now.Minute.ToString().Length == 1)
                {
                    lblHours.Text += "0" + DateTime.Now.Minute.ToString();

                }
                else
                {
                    lblHours.Text += DateTime.Now.Minute.ToString();
                }
                lblHours.Text+="PM";
            }
            else if (DateTime.Now.Hour == 12)
            {
                lblHours.Text = "12" + ":";
                if (DateTime.Now.Minute.ToString().Length == 1)
                {
                    lblHours.Text += "0" + DateTime.Now.Minute.ToString();

                }
                else
                {
                    lblHours.Text += DateTime.Now.Minute.ToString();
                }
                lblHours.Text+="PM";
            }
            lblDay.Text = DateTime.Now.DayOfWeek.ToString();
            //this is because the DateTIme.now.Date returns a time bit which i dont want
            string CurrentMonth = String.Format("{0:MMMM}", DateTime.Now);
            lblDate.Text = DateTime.Now.Day+"/"+CurrentMonth;
            t.Interval = 1000 * 60;
            
        }
        public void g_Detected(object sender, PinStatusEventArgs e)
        {         
            //start fade out timer
            edges++;
            if (edges == 2)
            {
                //t.Enabled = true;
                for (int i = 0; i < 20; i++)
                {
                    this.Opacity -= 0.05;
                    System.Threading.Thread.Sleep(10);
                }
                this.Close();
            }
        }

        private void DateAndTime_Load(object sender, EventArgs e)
        {

        }
        private void DateAndTime_Click(object sender, EventArgs e)
        {
            tn.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
