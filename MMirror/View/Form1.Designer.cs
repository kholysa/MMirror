namespace MMirror
{
    partial class Form1
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
            this.currentWeather = new System.Windows.Forms.Label();
            this.currentForecast1 = new System.Windows.Forms.Label();
            this.currentHumidity = new System.Windows.Forms.Label();
            this.currentRain = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tomorrow = new System.Windows.Forms.Label();
            this.tomorrow2 = new System.Windows.Forms.Label();
            this.tomorrow3 = new System.Windows.Forms.Label();
            this.tomorrow4 = new System.Windows.Forms.Label();
            this.forecastLo1 = new System.Windows.Forms.Label();
            this.forecastLo2 = new System.Windows.Forms.Label();
            this.forecastLo3 = new System.Windows.Forms.Label();
            this.forecastLo4 = new System.Windows.Forms.Label();
            this.forecastTemp1 = new System.Windows.Forms.Label();
            this.forecastTemp2 = new System.Windows.Forms.Label();
            this.forecastTemp3 = new System.Windows.Forms.Label();
            this.forecastTemp4 = new System.Windows.Forms.Label();
            this.currentTime4 = new System.Windows.Forms.Label();
            this.currentTime3 = new System.Windows.Forms.Label();
            this.currentTime2 = new System.Windows.Forms.Label();
            this.currentTime1 = new System.Windows.Forms.Label();
            this.forecastWeather = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.currentLocation = new System.Windows.Forms.Label();
            this.currentSnow = new System.Windows.Forms.Label();
            this.currentForecast4 = new System.Windows.Forms.Label();
            this.currentForecast3 = new System.Windows.Forms.Label();
            this.currentForecast2 = new System.Windows.Forms.Label();
            this.currentHumidityIMG = new System.Windows.Forms.PictureBox();
            this.rainIMG = new System.Windows.Forms.PictureBox();
            this.snowIMG = new System.Windows.Forms.PictureBox();
            this.forecastIMG1 = new System.Windows.Forms.PictureBox();
            this.forecastIMG2 = new System.Windows.Forms.PictureBox();
            this.forecastIMG3 = new System.Windows.Forms.PictureBox();
            this.forecastIMG4 = new System.Windows.Forms.PictureBox();
            this.currentImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentHumidityIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastIMG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastIMG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastIMG3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastIMG4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // currentWeather
            // 
            this.currentWeather.AutoSize = true;
            this.currentWeather.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentWeather.ForeColor = System.Drawing.Color.White;
            this.currentWeather.Location = new System.Drawing.Point(8, 102);
            this.currentWeather.Name = "currentWeather";
            this.currentWeather.Size = new System.Drawing.Size(147, 56);
            this.currentWeather.TabIndex = 0;
            this.currentWeather.Text = "label1";
            this.currentWeather.Click += new System.EventHandler(this.label1_Click);
            // 
            // currentForecast1
            // 
            this.currentForecast1.AutoSize = true;
            this.currentForecast1.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentForecast1.ForeColor = System.Drawing.Color.White;
            this.currentForecast1.Location = new System.Drawing.Point(2, 282);
            this.currentForecast1.Name = "currentForecast1";
            this.currentForecast1.Size = new System.Drawing.Size(91, 32);
            this.currentForecast1.TabIndex = 1;
            this.currentForecast1.Text = "label2";
            // 
            // currentHumidity
            // 
            this.currentHumidity.AutoSize = true;
            this.currentHumidity.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentHumidity.ForeColor = System.Drawing.Color.White;
            this.currentHumidity.Location = new System.Drawing.Point(106, 375);
            this.currentHumidity.Name = "currentHumidity";
            this.currentHumidity.Size = new System.Drawing.Size(152, 56);
            this.currentHumidity.TabIndex = 2;
            this.currentHumidity.Text = "label3";
            // 
            // currentRain
            // 
            this.currentRain.AutoSize = true;
            this.currentRain.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentRain.ForeColor = System.Drawing.Color.White;
            this.currentRain.Location = new System.Drawing.Point(105, 439);
            this.currentRain.Name = "currentRain";
            this.currentRain.Size = new System.Drawing.Size(153, 56);
            this.currentRain.TabIndex = 3;
            this.currentRain.Text = "label4";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.currentImage);
            this.panel1.Controls.Add(this.forecastIMG4);
            this.panel1.Controls.Add(this.forecastIMG3);
            this.panel1.Controls.Add(this.forecastIMG2);
            this.panel1.Controls.Add(this.forecastIMG1);
            this.panel1.Controls.Add(this.snowIMG);
            this.panel1.Controls.Add(this.rainIMG);
            this.panel1.Controls.Add(this.currentHumidityIMG);
            this.panel1.Controls.Add(this.currentHumidity);
            this.panel1.Controls.Add(this.Tomorrow);
            this.panel1.Controls.Add(this.tomorrow2);
            this.panel1.Controls.Add(this.tomorrow3);
            this.panel1.Controls.Add(this.tomorrow4);
            this.panel1.Controls.Add(this.forecastLo1);
            this.panel1.Controls.Add(this.forecastLo2);
            this.panel1.Controls.Add(this.forecastLo3);
            this.panel1.Controls.Add(this.forecastLo4);
            this.panel1.Controls.Add(this.forecastTemp1);
            this.panel1.Controls.Add(this.forecastTemp2);
            this.panel1.Controls.Add(this.forecastTemp3);
            this.panel1.Controls.Add(this.forecastTemp4);
            this.panel1.Controls.Add(this.currentTime4);
            this.panel1.Controls.Add(this.currentTime3);
            this.panel1.Controls.Add(this.currentTime2);
            this.panel1.Controls.Add(this.currentTime1);
            this.panel1.Controls.Add(this.forecastWeather);
            this.panel1.Controls.Add(this.location);
            this.panel1.Controls.Add(this.currentLocation);
            this.panel1.Controls.Add(this.currentSnow);
            this.panel1.Controls.Add(this.currentForecast4);
            this.panel1.Controls.Add(this.currentForecast3);
            this.panel1.Controls.Add(this.currentForecast2);
            this.panel1.Controls.Add(this.currentRain);
            this.panel1.Controls.Add(this.currentForecast1);
            this.panel1.Controls.Add(this.currentWeather);
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1894, 1032);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Tomorrow
            // 
            this.Tomorrow.AutoSize = true;
            this.Tomorrow.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tomorrow.ForeColor = System.Drawing.Color.White;
            this.Tomorrow.Location = new System.Drawing.Point(1467, 116);
            this.Tomorrow.Name = "Tomorrow";
            this.Tomorrow.Size = new System.Drawing.Size(98, 38);
            this.Tomorrow.TabIndex = 32;
            this.Tomorrow.Text = "label1";
            // 
            // tomorrow2
            // 
            this.tomorrow2.AutoSize = true;
            this.tomorrow2.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tomorrow2.ForeColor = System.Drawing.Color.White;
            this.tomorrow2.Location = new System.Drawing.Point(1467, 232);
            this.tomorrow2.Name = "tomorrow2";
            this.tomorrow2.Size = new System.Drawing.Size(98, 38);
            this.tomorrow2.TabIndex = 31;
            this.tomorrow2.Text = "label1";
            // 
            // tomorrow3
            // 
            this.tomorrow3.AutoSize = true;
            this.tomorrow3.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tomorrow3.ForeColor = System.Drawing.Color.White;
            this.tomorrow3.Location = new System.Drawing.Point(1467, 333);
            this.tomorrow3.Name = "tomorrow3";
            this.tomorrow3.Size = new System.Drawing.Size(98, 38);
            this.tomorrow3.TabIndex = 30;
            this.tomorrow3.Text = "label1";
            // 
            // tomorrow4
            // 
            this.tomorrow4.AutoSize = true;
            this.tomorrow4.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tomorrow4.ForeColor = System.Drawing.Color.White;
            this.tomorrow4.Location = new System.Drawing.Point(1467, 449);
            this.tomorrow4.Name = "tomorrow4";
            this.tomorrow4.Size = new System.Drawing.Size(98, 38);
            this.tomorrow4.TabIndex = 29;
            this.tomorrow4.Text = "label1";
            // 
            // forecastLo1
            // 
            this.forecastLo1.AutoSize = true;
            this.forecastLo1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLo1.ForeColor = System.Drawing.Color.LightGray;
            this.forecastLo1.Location = new System.Drawing.Point(1810, 114);
            this.forecastLo1.Name = "forecastLo1";
            this.forecastLo1.Size = new System.Drawing.Size(108, 41);
            this.forecastLo1.TabIndex = 24;
            this.forecastLo1.Text = "label1";
            // 
            // forecastLo2
            // 
            this.forecastLo2.AutoSize = true;
            this.forecastLo2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLo2.ForeColor = System.Drawing.Color.LightGray;
            this.forecastLo2.Location = new System.Drawing.Point(1810, 226);
            this.forecastLo2.Name = "forecastLo2";
            this.forecastLo2.Size = new System.Drawing.Size(108, 41);
            this.forecastLo2.TabIndex = 23;
            this.forecastLo2.Text = "label1";
            // 
            // forecastLo3
            // 
            this.forecastLo3.AutoSize = true;
            this.forecastLo3.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLo3.ForeColor = System.Drawing.Color.LightGray;
            this.forecastLo3.Location = new System.Drawing.Point(1810, 330);
            this.forecastLo3.Name = "forecastLo3";
            this.forecastLo3.Size = new System.Drawing.Size(108, 41);
            this.forecastLo3.TabIndex = 22;
            this.forecastLo3.Text = "label1";
            // 
            // forecastLo4
            // 
            this.forecastLo4.AutoSize = true;
            this.forecastLo4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLo4.ForeColor = System.Drawing.Color.LightGray;
            this.forecastLo4.Location = new System.Drawing.Point(1810, 447);
            this.forecastLo4.Name = "forecastLo4";
            this.forecastLo4.Size = new System.Drawing.Size(108, 41);
            this.forecastLo4.TabIndex = 21;
            this.forecastLo4.Text = "label1";
            // 
            // forecastTemp1
            // 
            this.forecastTemp1.AutoSize = true;
            this.forecastTemp1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastTemp1.ForeColor = System.Drawing.Color.White;
            this.forecastTemp1.Location = new System.Drawing.Point(1695, 102);
            this.forecastTemp1.Name = "forecastTemp1";
            this.forecastTemp1.Size = new System.Drawing.Size(147, 56);
            this.forecastTemp1.TabIndex = 20;
            this.forecastTemp1.Text = "label1";
            // 
            // forecastTemp2
            // 
            this.forecastTemp2.AutoSize = true;
            this.forecastTemp2.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastTemp2.ForeColor = System.Drawing.Color.White;
            this.forecastTemp2.Location = new System.Drawing.Point(1695, 214);
            this.forecastTemp2.Name = "forecastTemp2";
            this.forecastTemp2.Size = new System.Drawing.Size(147, 56);
            this.forecastTemp2.TabIndex = 19;
            this.forecastTemp2.Text = "label1";
            // 
            // forecastTemp3
            // 
            this.forecastTemp3.AutoSize = true;
            this.forecastTemp3.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastTemp3.ForeColor = System.Drawing.Color.White;
            this.forecastTemp3.Location = new System.Drawing.Point(1695, 318);
            this.forecastTemp3.Name = "forecastTemp3";
            this.forecastTemp3.Size = new System.Drawing.Size(147, 56);
            this.forecastTemp3.TabIndex = 18;
            this.forecastTemp3.Text = "label1";
            // 
            // forecastTemp4
            // 
            this.forecastTemp4.AutoSize = true;
            this.forecastTemp4.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastTemp4.ForeColor = System.Drawing.Color.White;
            this.forecastTemp4.Location = new System.Drawing.Point(1695, 435);
            this.forecastTemp4.Name = "forecastTemp4";
            this.forecastTemp4.Size = new System.Drawing.Size(147, 56);
            this.forecastTemp4.TabIndex = 17;
            this.forecastTemp4.Text = "label1";
            // 
            // currentTime4
            // 
            this.currentTime4.AutoSize = true;
            this.currentTime4.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime4.ForeColor = System.Drawing.Color.White;
            this.currentTime4.Location = new System.Drawing.Point(250, 318);
            this.currentTime4.Name = "currentTime4";
            this.currentTime4.Size = new System.Drawing.Size(75, 32);
            this.currentTime4.TabIndex = 15;
            this.currentTime4.Text = "label";
            // 
            // currentTime3
            // 
            this.currentTime3.AutoSize = true;
            this.currentTime3.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime3.ForeColor = System.Drawing.Color.White;
            this.currentTime3.Location = new System.Drawing.Point(167, 318);
            this.currentTime3.Name = "currentTime3";
            this.currentTime3.Size = new System.Drawing.Size(91, 32);
            this.currentTime3.TabIndex = 14;
            this.currentTime3.Text = "label6";
            // 
            // currentTime2
            // 
            this.currentTime2.AutoSize = true;
            this.currentTime2.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime2.ForeColor = System.Drawing.Color.White;
            this.currentTime2.Location = new System.Drawing.Point(86, 318);
            this.currentTime2.Name = "currentTime2";
            this.currentTime2.Size = new System.Drawing.Size(90, 32);
            this.currentTime2.TabIndex = 13;
            this.currentTime2.Text = "label5";
            // 
            // currentTime1
            // 
            this.currentTime1.AutoSize = true;
            this.currentTime1.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime1.ForeColor = System.Drawing.Color.White;
            this.currentTime1.Location = new System.Drawing.Point(3, 318);
            this.currentTime1.Name = "currentTime1";
            this.currentTime1.Size = new System.Drawing.Size(91, 32);
            this.currentTime1.TabIndex = 12;
            this.currentTime1.Text = "label2";
            // 
            // forecastWeather
            // 
            this.forecastWeather.AutoSize = true;
            this.forecastWeather.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastWeather.ForeColor = System.Drawing.Color.White;
            this.forecastWeather.Location = new System.Drawing.Point(1431, 9);
            this.forecastWeather.Name = "forecastWeather";
            this.forecastWeather.Size = new System.Drawing.Size(451, 56);
            this.forecastWeather.TabIndex = 11;
            this.forecastWeather.Text = "Forecasted Weather";
            this.forecastWeather.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.forecastWeather.Click += new System.EventHandler(this.forecastWeather_Click);
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.ForeColor = System.Drawing.Color.White;
            this.location.Location = new System.Drawing.Point(900, 9);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(147, 56);
            this.location.TabIndex = 10;
            this.location.Text = "label1";
            // 
            // currentLocation
            // 
            this.currentLocation.AutoSize = true;
            this.currentLocation.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLocation.ForeColor = System.Drawing.Color.White;
            this.currentLocation.Location = new System.Drawing.Point(13, 9);
            this.currentLocation.Name = "currentLocation";
            this.currentLocation.Size = new System.Drawing.Size(147, 56);
            this.currentLocation.TabIndex = 9;
            this.currentLocation.Text = "label1";
            // 
            // currentSnow
            // 
            this.currentSnow.AutoSize = true;
            this.currentSnow.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSnow.ForeColor = System.Drawing.Color.White;
            this.currentSnow.Location = new System.Drawing.Point(105, 495);
            this.currentSnow.Name = "currentSnow";
            this.currentSnow.Size = new System.Drawing.Size(153, 56);
            this.currentSnow.TabIndex = 8;
            this.currentSnow.Text = "label4";
            // 
            // currentForecast4
            // 
            this.currentForecast4.AutoSize = true;
            this.currentForecast4.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentForecast4.ForeColor = System.Drawing.Color.White;
            this.currentForecast4.Location = new System.Drawing.Point(250, 282);
            this.currentForecast4.Name = "currentForecast4";
            this.currentForecast4.Size = new System.Drawing.Size(75, 32);
            this.currentForecast4.TabIndex = 6;
            this.currentForecast4.Text = "label";
            // 
            // currentForecast3
            // 
            this.currentForecast3.AutoSize = true;
            this.currentForecast3.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentForecast3.ForeColor = System.Drawing.Color.White;
            this.currentForecast3.Location = new System.Drawing.Point(167, 282);
            this.currentForecast3.Name = "currentForecast3";
            this.currentForecast3.Size = new System.Drawing.Size(91, 32);
            this.currentForecast3.TabIndex = 5;
            this.currentForecast3.Text = "label6";
            // 
            // currentForecast2
            // 
            this.currentForecast2.AutoSize = true;
            this.currentForecast2.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentForecast2.ForeColor = System.Drawing.Color.White;
            this.currentForecast2.Location = new System.Drawing.Point(85, 282);
            this.currentForecast2.Name = "currentForecast2";
            this.currentForecast2.Size = new System.Drawing.Size(90, 32);
            this.currentForecast2.TabIndex = 4;
            this.currentForecast2.Text = "label5";
            // 
            // currentHumidityIMG
            // 
            this.currentHumidityIMG.Location = new System.Drawing.Point(9, 361);
            this.currentHumidityIMG.Name = "currentHumidityIMG";
            this.currentHumidityIMG.Size = new System.Drawing.Size(50, 70);
            this.currentHumidityIMG.TabIndex = 33;
            this.currentHumidityIMG.TabStop = false;
            // 
            // rainIMG
            // 
            this.rainIMG.Location = new System.Drawing.Point(8, 445);
            this.rainIMG.Name = "rainIMG";
            this.rainIMG.Size = new System.Drawing.Size(50, 50);
            this.rainIMG.TabIndex = 34;
            this.rainIMG.TabStop = false;
            // 
            // snowIMG
            // 
            this.snowIMG.Location = new System.Drawing.Point(8, 514);
            this.snowIMG.Name = "snowIMG";
            this.snowIMG.Size = new System.Drawing.Size(50, 50);
            this.snowIMG.TabIndex = 35;
            this.snowIMG.TabStop = false;
            // 
            // forecastIMG1
            // 
            this.forecastIMG1.Location = new System.Drawing.Point(1605, 108);
            this.forecastIMG1.Name = "forecastIMG1";
            this.forecastIMG1.Size = new System.Drawing.Size(50, 50);
            this.forecastIMG1.TabIndex = 36;
            this.forecastIMG1.TabStop = false;
            // 
            // forecastIMG2
            // 
            this.forecastIMG2.Location = new System.Drawing.Point(1605, 214);
            this.forecastIMG2.Name = "forecastIMG2";
            this.forecastIMG2.Size = new System.Drawing.Size(50, 50);
            this.forecastIMG2.TabIndex = 37;
            this.forecastIMG2.TabStop = false;
            // 
            // forecastIMG3
            // 
            this.forecastIMG3.Location = new System.Drawing.Point(1605, 318);
            this.forecastIMG3.Name = "forecastIMG3";
            this.forecastIMG3.Size = new System.Drawing.Size(50, 50);
            this.forecastIMG3.TabIndex = 38;
            this.forecastIMG3.TabStop = false;
            // 
            // forecastIMG4
            // 
            this.forecastIMG4.Location = new System.Drawing.Point(1605, 435);
            this.forecastIMG4.Name = "forecastIMG4";
            this.forecastIMG4.Size = new System.Drawing.Size(50, 50);
            this.forecastIMG4.TabIndex = 39;
            this.forecastIMG4.TabStop = false;
            // 
            // currentImage
            // 
            this.currentImage.Location = new System.Drawing.Point(23, 177);
            this.currentImage.Name = "currentImage";
            this.currentImage.Size = new System.Drawing.Size(50, 50);
            this.currentImage.TabIndex = 40;
            this.currentImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentHumidityIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastIMG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastIMG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastIMG3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastIMG4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label currentWeather;
        private System.Windows.Forms.Label currentForecast1;
        private System.Windows.Forms.Label currentHumidity;
        private System.Windows.Forms.Label currentRain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label currentForecast4;
        private System.Windows.Forms.Label currentForecast3;
        private System.Windows.Forms.Label currentForecast2;
        private System.Windows.Forms.Label currentSnow;
        private System.Windows.Forms.Label currentLocation;
        private System.Windows.Forms.Label forecastWeather;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label currentTime4;
        private System.Windows.Forms.Label currentTime3;
        private System.Windows.Forms.Label currentTime2;
        private System.Windows.Forms.Label currentTime1;
        private System.Windows.Forms.Label forecastTemp1;
        private System.Windows.Forms.Label forecastTemp2;
        private System.Windows.Forms.Label forecastTemp3;
        private System.Windows.Forms.Label forecastTemp4;
        private System.Windows.Forms.Label forecastLo1;
        private System.Windows.Forms.Label forecastLo2;
        private System.Windows.Forms.Label forecastLo3;
        private System.Windows.Forms.Label forecastLo4;
        private System.Windows.Forms.Label Tomorrow;
        private System.Windows.Forms.Label tomorrow2;
        private System.Windows.Forms.Label tomorrow3;
        private System.Windows.Forms.Label tomorrow4;
        private System.Windows.Forms.PictureBox currentImage;
        private System.Windows.Forms.PictureBox forecastIMG4;
        private System.Windows.Forms.PictureBox forecastIMG3;
        private System.Windows.Forms.PictureBox forecastIMG2;
        private System.Windows.Forms.PictureBox forecastIMG1;
        private System.Windows.Forms.PictureBox snowIMG;
        private System.Windows.Forms.PictureBox rainIMG;
        private System.Windows.Forms.PictureBox currentHumidityIMG;

    }
}

