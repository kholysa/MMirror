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

namespace MMirror.View
{
    public partial class stockView : Form
    {
        public stockView()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
       
        }

        private void stockView_Load(object sender, EventArgs e)
        {
            MMirrorManager mmc = MMirrorManager.instance;
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font("Georgia", 16);
            stocksBindingSource.Add(mmc.getStocks()[0]);
            stocksBindingSource.Add(mmc.getStocks()[1]);
            stocksBindingSource.Add(mmc.getStocks()[2]);
            stocksBindingSource.Add(mmc.getStocks()[3]);
            dataGridView1.Rows[0].Selected = true; ;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
               dataGridView1.Columns[i].HeaderCell.Style= style;
               dataGridView1.Columns[i].DefaultCellStyle.ApplyStyle(style);
               
            }
            for (int i = 0; i < mmc.getStocks().Count; i++)
            {
                if (mmc.getStocks()[i].volatility.Contains("+"))
               {
                   dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                   dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
               }
               else
               {
                   dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                   dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
               
               }
            }
            if (mmc.getStocks()[0].volatility.Contains("+"))
                dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Green;
            else
                dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Red;
            dataGridView1.DataSource = stocksBindingSource;

        //    DataGridViewColumn column = new DataGridViewTextBoxColumn();
          //  column.DataPropertyName = "Name";
            //column.Name = "Knight";
            //dataGridView1.Columns.Add(column);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }
        private void onClicked(object sender, EventArgs e)
        {
            
            Form1 windows = new Form1();
            windows.Show();
            this.Hide();
         
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
