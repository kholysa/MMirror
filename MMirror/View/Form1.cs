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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MMirrorManager mmc = MMirrorManager.Instance; 
            
            label1.Text=mmc.getWeather()[0].toString();
           
 
        }
    }
}
