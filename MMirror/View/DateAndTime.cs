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
        System.Windows.Forms.Timer t = null;
        public DateAndTime()
        {
            /* InputPinConfiguration p = new InputPinConfiguration(ConnectorPin.P1Pin07.ToProcessor());
          GpioConnection g = new GpioConnection(p);
          g.PinStatusChanged += g_Detected;
            
          */
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            //let the labels update every minute
            //this is done by an event being raised every minute
            //the event modifies the labels
            StartTimer();
      
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
            if (DateTime.Now.Hour < 12)
            {
                lblHours.Text = DateTime.Now.Hour.ToString()+":";
                lblHours.Text += DateTime.Now.Minute.ToString();
                lblHours.Text+="AM";
            }
            else if (DateTime.Now.Hour == 0)
            {
                lblHours.Text = 12 + "" + ":";
                lblHours.Text += DateTime.Now.Minute.ToString();
                lblHours.Text+="AM";
            }
            else if (DateTime.Now.Hour > 12)
            {
                lblHours.Text = (DateTime.Now.Hour - 12).ToString() + ":";
                lblHours.Text += DateTime.Now.Minute.ToString();
                lblHours.Text+="PM";
            }
            else if (DateTime.Now.Hour == 12)
            {
                lblHours.Text = "12" + ":";
                lblHours.Text += DateTime.Now.Minute.ToString();
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
            edges++;
            if (edges == 1)
            {
                this.Close();
                edges = 0;
            }
        }

        private void DateAndTime_Load(object sender, EventArgs e)
        {

        }
        private void DateAndTime_Click(object sender, EventArgs e)
        {
            WeatherView windows = new WeatherView();
            windows.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
