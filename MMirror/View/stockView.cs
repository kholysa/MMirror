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
using Raspberry.IO.GeneralPurpose;
using MMirror.Controller;
namespace MMirror.View
{
    public partial class stockView : Form
    {
        int edges = 0;
        public stockView()
        {
           /* InputPinConfiguration p = new InputPinConfiguration(ConnectorPin.P1Pin07.ToProcessor());
            GpioConnection g = new GpioConnection(p);
            g.PinStatusChanged += g_Detected;
            
            */
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            
       
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

            label9.Text = mmc.getStock(0).closePrice+"";
            label10.Text = mmc.getStock(1).closePrice + "";

            label17.Text = mmc.getStock(0).avgVolume + "";
            label18.Text = mmc.getStock(1).avgVolume + "";

            label25.Text = mmc.getStock(0).volume + "";
            label26.Text = mmc.getStock(1).volume + "";

            label33.Text = mmc.getStock(0).volatility;
            label34.Text = mmc.getStock(1).volatility;


            try
            {
                stockController si = new stockController();
                si.getStockFile();
            }
            catch (NullReferenceException)
            {
                label42.Show();
                ErrorLabel();
            }
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
            label42.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }
        private void onClicked(object sender, EventArgs e)
        {
            DateAndTime windows = new DateAndTime();
            windows.Show();
            this.Hide();
         
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
                label9.ForeColor = Color.Green;
                label17.ForeColor = Color.Green;
                label25.ForeColor = Color.Green;
                label33.ForeColor = Color.Green;
            }
            else
            {
                label1.ForeColor = Color.Red;
                label9.ForeColor = Color.Red;
                label17.ForeColor = Color.Red;
                label25.ForeColor = Color.Red;
                label33.ForeColor = Color.Red;
            }
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label34_TextChanged(object sender, EventArgs e)
        {
            if (label34.Text.Contains('+'))
            {
                label34.ForeColor = Color.Green;
                label2.ForeColor = Color.Green;
                label10.ForeColor = Color.Green;
                label18.ForeColor = Color.Green;
                label26.ForeColor = Color.Green;
            }
            else
            {
                label34.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
                label10.ForeColor = Color.Red;
                label18.ForeColor = Color.Red;
                label26.ForeColor = Color.Red;
            }
        }
    }
}
