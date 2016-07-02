namespace MMirror.View
{
    partial class stockView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.stockNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volatilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMirrorManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMirrorManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 1080);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.onClicked);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockNameDataGridViewTextBoxColumn,
            this.closePriceDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn,
            this.avgVolumeDataGridViewTextBoxColumn,
            this.volatilityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stocksBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(22, 81);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1627, 324);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(7, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 347);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // stockNameDataGridViewTextBoxColumn
            // 
            this.stockNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stockNameDataGridViewTextBoxColumn.DataPropertyName = "stockName";
            this.stockNameDataGridViewTextBoxColumn.HeaderText = "Stock Name";
            this.stockNameDataGridViewTextBoxColumn.Name = "stockNameDataGridViewTextBoxColumn";
            this.stockNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockNameDataGridViewTextBoxColumn.Width = 122;
            // 
            // closePriceDataGridViewTextBoxColumn
            // 
            this.closePriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.closePriceDataGridViewTextBoxColumn.DataPropertyName = "closePrice";
            this.closePriceDataGridViewTextBoxColumn.HeaderText = "Closing Price";
            this.closePriceDataGridViewTextBoxColumn.Name = "closePriceDataGridViewTextBoxColumn";
            this.closePriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.closePriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "Volume";
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.ReadOnly = true;
            this.volumeDataGridViewTextBoxColumn.Width = 99;
            // 
            // avgVolumeDataGridViewTextBoxColumn
            // 
            this.avgVolumeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.avgVolumeDataGridViewTextBoxColumn.DataPropertyName = "avgVolume";
            this.avgVolumeDataGridViewTextBoxColumn.HeaderText = "Average Volume";
            this.avgVolumeDataGridViewTextBoxColumn.Name = "avgVolumeDataGridViewTextBoxColumn";
            this.avgVolumeDataGridViewTextBoxColumn.ReadOnly = true;
            this.avgVolumeDataGridViewTextBoxColumn.Width = 149;
            // 
            // volatilityDataGridViewTextBoxColumn
            // 
            this.volatilityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.volatilityDataGridViewTextBoxColumn.DataPropertyName = "volatility";
            this.volatilityDataGridViewTextBoxColumn.HeaderText = "Volatility";
            this.volatilityDataGridViewTextBoxColumn.Name = "volatilityDataGridViewTextBoxColumn";
            this.volatilityDataGridViewTextBoxColumn.ReadOnly = true;
            this.volatilityDataGridViewTextBoxColumn.Width = 5;
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataSource = typeof(MMirror.Model.stocks);
            // 
            // mMirrorManagerBindingSource
            // 
            this.mMirrorManagerBindingSource.DataSource = typeof(MMirror.Model.MMirrorManager);
            // 
            // stockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.panel1);
            this.Name = "stockView";
            this.Text = "stockView";
            this.Load += new System.EventHandler(this.stockView_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMirrorManagerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mMirrorManagerBindingSource;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgVolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volatilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
    }
}