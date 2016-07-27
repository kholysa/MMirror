using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace MMirror.View
{
    public partial class ErrorBox : Form
    {
        public Label Message;
        public ErrorBox()
        {
            FormBorderStyle = FormBorderStyle.None;

            InitializeComponent();
            Message = label1;
        }

        private void ErrorBox_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer t = new Timer();
            t.Interval = 3000;
            t.Tick += new EventHandler(t_Elapsed);
            t.Start();
        }
        void t_Elapsed(object sender, EventArgs e)
        {
            this.Close();                  
        }
    }
}
