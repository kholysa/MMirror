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
using Raspberry.IO.GeneralPurpose;
using MMirror.Controller;
namespace MMirror.View
{
    public partial class stockView : Form
    {
        int edges = 0;
        //t is the fade in/out timer
        //tn is the error timer
        Timer t;
        Timer tn;
        stockController sc = new stockController();
                
        public stockView()
        {
            //when implementing this, just call whatever the onCLick calls, hopefully we wont crash and fail :))))
           /* InputPinConfiguration p = new InputPinConfiguration(ConnectorPin.P1Pin07.ToProcessor());
            GpioConnection g = new GpioConnection(p);
            g.PinStatusChanged += g_Detected;
            
            */
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            t = new Timer();
            t.Interval = 10;
            t.Tick += t_Tick;

            this.Opacity = 0;

            MMirrorManager mmc = MMirrorManager.instance;
            label42.Hide();
            List<Label> stockData = new List<Label>(40);
            var c = GetAll(this, typeof(Label));
            for (int i = 0; i < c.Count(); i++)
            {
                c.ElementAt(i).Text = "";
            }
            label42.Text = "No Internet Connection. Try again Later";

            label1.Text = mmc.getStock(0).stockName;
            label2.Text = mmc.getStock(1).stockName;
            label3.Text = mmc.getStock(2).stockName;
            label4.Text = mmc.getStock(3).stockName;

            if (mmc.getStock(4).stockName == "\"^FTSE\"")
                label5.Text = "FTSE 100";
            else if (mmc.getStock(4).stockName == "\"^FTMC\"")
                label5.Text = "FTSE 250";
            else if (mmc.getStock(4).stockName == "\"^N225\"")
                label5.Text = "NIKKEI";

            if (mmc.getStock(5).stockName == "\"BZZ15.NYM\"")
                label6.Text = "Brent Crude Oil";
            else if (mmc.getStock(5).stockName == "\"^GSPC\"")
                label6.Text = "S"+'&'+"P 500";
            else if (mmc.getStock(5).stockName == "\"WTI\"")
                label6.Text = "WTI";


            label9.Text = mmc.getStock(0).closePrice + "";
            label10.Text = mmc.getStock(1).closePrice + "";
            label11.Text = mmc.getStock(2).closePrice + "";
            label12.Text = mmc.getStock(3).closePrice + "";
            label13.Text = mmc.getStock(4).closePrice + "";
            label14.Text = mmc.getStock(4).closePrice + "";


            label33.Text = mmc.getStock(0).volatility;
            label34.Text = mmc.getStock(1).volatility;
            label35.Text = mmc.getStock(2).volatility;
            label36.Text = mmc.getStock(3).volatility;
            label21.Text = mmc.getStock(4).volatility;
            label22.Text = mmc.getStock(5).volatility;


            try
            {
                sc.getStockFile();
            }
            catch (Exception)
            {
            }
        }

        private void t_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 0.01)
            {
                
                t.Enabled = false;
                DateAndTime dt = new DateAndTime();
                dt.Show();
                dt.startFadeinTimer();
                this.Hide();


            }

            this.Opacity -= 0.05;
        }
        public void startFadeinTimer()
        {
            tn = new Timer();
            tn.Interval = 10;
            tn.Tick += tn_Tick;
            tn.Enabled = true;
        }

        void tn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                tn.Enabled = false;
            }
            this.Opacity += 0.1;

        }
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType()  == type);
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

        private void stockView_Load(object sender, EventArgs e)
        {
           
        }
        private void ErrorLabel()
        {
            System.Windows.Forms.Timer t = new Timer();
            t.Interval = 3000;
            t.Tick += new EventHandler(t_Elapsed);
            t.Start();
        }
        void t_Elapsed(object sender, EventArgs e)
        {
            //when three seconds have passed, hide the warning label
            label42.Hide();
            t.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //by this stage we know if we have an error or not
            if (sc.er is Exception)
            {
                label42.Show();
                ErrorLabel();
            }
        }
        private void onClicked(object sender, EventArgs e)
        {
            //start fade out timer
            t.Enabled = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label33_TextChanged(object sender, EventArgs e)
        {
            if (label33.Text.Contains('+'))
            {
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.ForeColor = Color.Red;
            }
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label34_TextChanged(object sender, EventArgs e)
        {
            if (label34.Text.Contains('+'))
            {
                label2.ForeColor = Color.Green;

            }
            else
            {
                label2.ForeColor = Color.Red;

            }
        }

        private void label21_TextChanged(object sender, EventArgs e)
        {
            if (label21.Text.Contains('+'))
            {
                label5.ForeColor = Color.Green;

            }
            else
            {
                label5.ForeColor = Color.Red;

            }
        }

        private void label35_TextChanged(object sender, EventArgs e)
        {
            if (label35.Text.Contains('+'))
            {
                label3.ForeColor = Color.Green;

            }
            else
            {
                label3.ForeColor = Color.Red;

            }
        }

        private void label36_TextChanged(object sender, EventArgs e)
        {
            if (label36.Text.Contains('+'))
            {
                label4.ForeColor = Color.Green;

            }
            else
            {
                label4.ForeColor = Color.Red;

            }
        }

        private void label22_TextChanged(object sender, EventArgs e)
        {
            if (label2.Text.Contains('+'))
            {
                label6.ForeColor = Color.Green;

            }
            else
            {
                label6.ForeColor = Color.Red;

            }
        }
    }
}
