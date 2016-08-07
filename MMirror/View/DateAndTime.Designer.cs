namespace MMirror.View
{
    partial class DateAndTime
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDay);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblHours);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 1081);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.DateAndTime_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Georgia", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.Location = new System.Drawing.Point(71, 41);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(178, 65);
            this.lblDay.TabIndex = 9;
            this.lblDay.Text = "label4";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Goudy Old Style", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(71, 247);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(136, 55);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "label4";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Goudy Old Style", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.ForeColor = System.Drawing.Color.White;
            this.lblHours.Location = new System.Drawing.Point(71, 149);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(136, 55);
            this.lblHours.TabIndex = 5;
            this.lblHours.Text = "label1";
            // 
            // DateAndTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1898, 1025);
            this.Controls.Add(this.panel1);
            this.Name = "DateAndTime";
            this.Text = "DateAndTime";
            this.Load += new System.EventHandler(this.DateAndTime_Load);
            this.Click += new System.EventHandler(this.DateAndTime_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblHours;

    }
}