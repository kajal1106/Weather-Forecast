namespace Assignment___Weather_Forecast
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            searchButton = new Button();
            textBoxSearchCity = new TextBox();
            labelCityName = new Label();
            labelTemp = new Label();
            weatherIcon = new PictureBox();
            labelHighTemp = new Label();
            label2 = new Label();
            labelLowTemp = new Label();
            labelTempInfo = new Label();
            pictureBox9 = new PictureBox();
            labelSunrise = new Label();
            pictureBox10 = new PictureBox();
            labelSunset = new Label();
            labelWind = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            labelPressure = new Label();
            pictureBox4 = new PictureBox();
            labelHumidity = new Label();
            pictureBox5 = new PictureBox();
            labelVisibility = new Label();
            labelCurrentDateTime = new Label();
            labelMoonset = new Label();
            pictureBox1 = new PictureBox();
            labelMoonrise = new Label();
            pictureBox15 = new PictureBox();
            pictureBoxForecastHour6 = new PictureBox();
            pictureBoxForecastHour5 = new PictureBox();
            pictureBoxForecastHour4 = new PictureBox();
            pictureBoxForecastHour3 = new PictureBox();
            pictureBoxForecastHour2 = new PictureBox();
            pictureBoxForecastHour1 = new PictureBox();
            labelForecastHour6 = new Label();
            labelForecastHour5 = new Label();
            labelForecastHour4 = new Label();
            labelForecastHour3 = new Label();
            labelForecastHour2 = new Label();
            labelForecastHour1 = new Label();
            groupBoxWeeklyForecast = new GroupBox();
            HourlyDesc2 = new Label();
            HourlyDesc6 = new Label();
            HourlyDesc5 = new Label();
            HourlyDesc4 = new Label();
            HourlyDesc3 = new Label();
            HourlyDesc1 = new Label();
            HourlyTemp6 = new Label();
            HourlyTemp5 = new Label();
            HourlyTemp4 = new Label();
            HourlyTemp3 = new Label();
            HourlyTemp2 = new Label();
            HourlyTemp1 = new Label();
            ((System.ComponentModel.ISupportInitialize)weatherIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForecastHour6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForecastHour5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForecastHour4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForecastHour3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForecastHour2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForecastHour1).BeginInit();
            groupBoxWeeklyForecast.SuspendLayout();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Transparent;
            searchButton.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            searchButton.FlatAppearance.BorderSize = 2;
            searchButton.ForeColor = SystemColors.Desktop;
            searchButton.Location = new Point(425, 25);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(101, 24);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // textBoxSearchCity
            // 
            textBoxSearchCity.AutoCompleteSource = AutoCompleteSource.FileSystem;
            textBoxSearchCity.BackColor = SystemColors.InactiveBorder;
            textBoxSearchCity.Location = new Point(196, 26);
            textBoxSearchCity.Name = "textBoxSearchCity";
            textBoxSearchCity.PlaceholderText = "Search City";
            textBoxSearchCity.Size = new Size(223, 23);
            textBoxSearchCity.TabIndex = 2;
            // 
            // labelCityName
            // 
            labelCityName.AutoSize = true;
            labelCityName.BackColor = Color.Transparent;
            labelCityName.FlatStyle = FlatStyle.Flat;
            labelCityName.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelCityName.ForeColor = Color.Black;
            labelCityName.Location = new Point(202, 63);
            labelCityName.Name = "labelCityName";
            labelCityName.Size = new Size(119, 30);
            labelCityName.TabIndex = 3;
            labelCityName.Text = "Athlone, IE";
            labelCityName.Click += labelCityName_Click;
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.BackColor = Color.Transparent;
            labelTemp.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTemp.ForeColor = Color.Black;
            labelTemp.Location = new Point(245, 100);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(64, 25);
            labelTemp.TabIndex = 4;
            labelTemp.Text = "100°C";
            labelTemp.Click += label1_Click;
            // 
            // weatherIcon
            // 
            weatherIcon.BackColor = Color.Transparent;
            weatherIcon.BackgroundImageLayout = ImageLayout.Zoom;
            weatherIcon.Image = Properties.Resources.cloudy;
            weatherIcon.Location = new Point(204, 100);
            weatherIcon.Name = "weatherIcon";
            weatherIcon.Size = new Size(40, 30);
            weatherIcon.SizeMode = PictureBoxSizeMode.Zoom;
            weatherIcon.TabIndex = 5;
            weatherIcon.TabStop = false;
            weatherIcon.Click += weatherIcon_Click;
            // 
            // labelHighTemp
            // 
            labelHighTemp.BackColor = Color.Transparent;
            labelHighTemp.ForeColor = Color.Black;
            labelHighTemp.Location = new Point(208, 144);
            labelHighTemp.Name = "labelHighTemp";
            labelHighTemp.Size = new Size(100, 23);
            labelHighTemp.TabIndex = 6;
            labelHighTemp.Text = "High: 105°C";
            labelHighTemp.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(274, 144);
            label2.Name = "label2";
            label2.Size = new Size(16, 15);
            label2.TabIndex = 7;
            label2.Text = " | ";
            label2.Click += label2_Click;
            // 
            // labelLowTemp
            // 
            labelLowTemp.AutoSize = true;
            labelLowTemp.BackColor = Color.Transparent;
            labelLowTemp.ForeColor = Color.Black;
            labelLowTemp.Location = new Point(289, 144);
            labelLowTemp.Name = "labelLowTemp";
            labelLowTemp.Size = new Size(60, 15);
            labelLowTemp.TabIndex = 8;
            labelLowTemp.Text = "Low: 50°C";
            labelLowTemp.Click += labelLowTemp_Click;
            // 
            // labelTempInfo
            // 
            labelTempInfo.AutoSize = true;
            labelTempInfo.BackColor = Color.Transparent;
            labelTempInfo.ForeColor = Color.Black;
            labelTempInfo.Location = new Point(311, 108);
            labelTempInfo.Name = "labelTempInfo";
            labelTempInfo.Size = new Size(243, 15);
            labelTempInfo.TabIndex = 9;
            labelTempInfo.Text = "Feels like 7°C. Overcast clouds. Gentle Breeze";
            labelTempInfo.Click += label1_Click_2;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Image = Properties.Resources.sunrise;
            pictureBox9.Location = new Point(208, 181);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(30, 24);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 42;
            pictureBox9.TabStop = false;
            // 
            // labelSunrise
            // 
            labelSunrise.AutoSize = true;
            labelSunrise.BackColor = Color.Transparent;
            labelSunrise.ForeColor = Color.Black;
            labelSunrise.Location = new Point(245, 185);
            labelSunrise.Name = "labelSunrise";
            labelSunrise.Size = new Size(51, 15);
            labelSunrise.TabIndex = 43;
            labelSunrise.Text = "07:45am";
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.Transparent;
            pictureBox10.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox10.Image = Properties.Resources.sunset;
            pictureBox10.Location = new Point(311, 181);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(30, 24);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 44;
            pictureBox10.TabStop = false;
            // 
            // labelSunset
            // 
            labelSunset.AutoSize = true;
            labelSunset.BackColor = Color.Transparent;
            labelSunset.ForeColor = Color.Black;
            labelSunset.Location = new Point(349, 185);
            labelSunset.Name = "labelSunset";
            labelSunset.Size = new Size(52, 15);
            labelSunset.TabIndex = 45;
            labelSunset.Text = "04:46pm";
            // 
            // labelWind
            // 
            labelWind.AutoSize = true;
            labelWind.BackColor = Color.Transparent;
            labelWind.ForeColor = Color.Black;
            labelWind.Location = new Point(234, 222);
            labelWind.Name = "labelWind";
            labelWind.Size = new Size(74, 15);
            labelWind.TabIndex = 46;
            labelWind.Text = "5.4m/s WSW";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = Properties.Resources.wind;
            pictureBox2.Location = new Point(208, 216);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Image = Properties.Resources.pressure;
            pictureBox3.Location = new Point(317, 216);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 49;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // labelPressure
            // 
            labelPressure.AutoSize = true;
            labelPressure.BackColor = Color.Transparent;
            labelPressure.ForeColor = Color.Black;
            labelPressure.Location = new Point(343, 222);
            labelPressure.Name = "labelPressure";
            labelPressure.Size = new Size(45, 15);
            labelPressure.TabIndex = 48;
            labelPressure.Text = "974hPa";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(399, 216);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 51;
            pictureBox4.TabStop = false;
            // 
            // labelHumidity
            // 
            labelHumidity.AutoSize = true;
            labelHumidity.BackColor = Color.Transparent;
            labelHumidity.ForeColor = Color.Black;
            labelHumidity.Location = new Point(425, 222);
            labelHumidity.Name = "labelHumidity";
            labelHumidity.Size = new Size(29, 15);
            labelHumidity.TabIndex = 50;
            labelHumidity.Text = "79%";
            labelHumidity.Click += label25_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Image = Properties.Resources.visibility;
            pictureBox5.Location = new Point(467, 216);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(20, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 52;
            pictureBox5.TabStop = false;
            // 
            // labelVisibility
            // 
            labelVisibility.AutoSize = true;
            labelVisibility.BackColor = Color.Transparent;
            labelVisibility.ForeColor = Color.Black;
            labelVisibility.Location = new Point(493, 222);
            labelVisibility.Name = "labelVisibility";
            labelVisibility.Size = new Size(45, 15);
            labelVisibility.TabIndex = 53;
            labelVisibility.Text = "10.0km";
            // 
            // labelCurrentDateTime
            // 
            labelCurrentDateTime.AutoSize = true;
            labelCurrentDateTime.BackColor = Color.Transparent;
            labelCurrentDateTime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCurrentDateTime.ForeColor = Color.Red;
            labelCurrentDateTime.Location = new Point(669, 22);
            labelCurrentDateTime.Name = "labelCurrentDateTime";
            labelCurrentDateTime.Size = new Size(119, 21);
            labelCurrentDateTime.TabIndex = 54;
            labelCurrentDateTime.Text = "Nov 2, 12:17pm";
            labelCurrentDateTime.Click += label1_Click_3;
            // 
            // labelMoonset
            // 
            labelMoonset.AutoSize = true;
            labelMoonset.BackColor = Color.Transparent;
            labelMoonset.ForeColor = Color.Black;
            labelMoonset.Location = new Point(551, 185);
            labelMoonset.Name = "labelMoonset";
            labelMoonset.Size = new Size(51, 15);
            labelMoonset.TabIndex = 60;
            labelMoonset.Text = "04:46am";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.moonset;
            pictureBox1.Location = new Point(512, 181);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            // 
            // labelMoonrise
            // 
            labelMoonrise.AutoSize = true;
            labelMoonrise.BackColor = Color.Transparent;
            labelMoonrise.ForeColor = Color.Black;
            labelMoonrise.Location = new Point(446, 185);
            labelMoonrise.Name = "labelMoonrise";
            labelMoonrise.Size = new Size(52, 15);
            labelMoonrise.TabIndex = 58;
            labelMoonrise.Text = "07:33pm";
            // 
            // pictureBox15
            // 
            pictureBox15.BackColor = Color.Transparent;
            pictureBox15.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox15.Image = Properties.Resources.moonrise;
            pictureBox15.Location = new Point(409, 181);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(30, 24);
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox15.TabIndex = 57;
            pictureBox15.TabStop = false;
            // 
            // pictureBoxForecastHour6
            // 
            pictureBoxForecastHour6.BackColor = Color.Transparent;
            pictureBoxForecastHour6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxForecastHour6.Image = Properties.Resources.cloudy;
            pictureBoxForecastHour6.Location = new Point(542, 70);
            pictureBoxForecastHour6.Name = "pictureBoxForecastHour6";
            pictureBoxForecastHour6.Size = new Size(50, 40);
            pictureBoxForecastHour6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxForecastHour6.TabIndex = 84;
            pictureBoxForecastHour6.TabStop = false;
            // 
            // pictureBoxForecastHour5
            // 
            pictureBoxForecastHour5.BackColor = Color.Transparent;
            pictureBoxForecastHour5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxForecastHour5.Image = Properties.Resources.cloudy;
            pictureBoxForecastHour5.Location = new Point(436, 70);
            pictureBoxForecastHour5.Name = "pictureBoxForecastHour5";
            pictureBoxForecastHour5.Size = new Size(50, 40);
            pictureBoxForecastHour5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxForecastHour5.TabIndex = 83;
            pictureBoxForecastHour5.TabStop = false;
            pictureBoxForecastHour5.Click += pictureBoxForecastHour5_Click;
            // 
            // pictureBoxForecastHour4
            // 
            pictureBoxForecastHour4.BackColor = Color.Transparent;
            pictureBoxForecastHour4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxForecastHour4.Image = Properties.Resources.cloudy;
            pictureBoxForecastHour4.Location = new Point(330, 70);
            pictureBoxForecastHour4.Name = "pictureBoxForecastHour4";
            pictureBoxForecastHour4.Size = new Size(50, 40);
            pictureBoxForecastHour4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxForecastHour4.TabIndex = 82;
            pictureBoxForecastHour4.TabStop = false;
            // 
            // pictureBoxForecastHour3
            // 
            pictureBoxForecastHour3.BackColor = Color.Transparent;
            pictureBoxForecastHour3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxForecastHour3.Image = Properties.Resources.cloudy;
            pictureBoxForecastHour3.Location = new Point(222, 70);
            pictureBoxForecastHour3.Name = "pictureBoxForecastHour3";
            pictureBoxForecastHour3.Size = new Size(50, 40);
            pictureBoxForecastHour3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxForecastHour3.TabIndex = 81;
            pictureBoxForecastHour3.TabStop = false;
            pictureBoxForecastHour3.Click += pictureBoxForecastHour3_Click;
            // 
            // pictureBoxForecastHour2
            // 
            pictureBoxForecastHour2.BackColor = Color.Transparent;
            pictureBoxForecastHour2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxForecastHour2.Image = Properties.Resources.cloudy;
            pictureBoxForecastHour2.Location = new Point(122, 70);
            pictureBoxForecastHour2.Name = "pictureBoxForecastHour2";
            pictureBoxForecastHour2.Size = new Size(50, 40);
            pictureBoxForecastHour2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxForecastHour2.TabIndex = 80;
            pictureBoxForecastHour2.TabStop = false;
            pictureBoxForecastHour2.Click += pictureBox13_Click;
            // 
            // pictureBoxForecastHour1
            // 
            pictureBoxForecastHour1.BackColor = Color.Transparent;
            pictureBoxForecastHour1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxForecastHour1.Image = Properties.Resources.cloudy;
            pictureBoxForecastHour1.Location = new Point(26, 70);
            pictureBoxForecastHour1.Name = "pictureBoxForecastHour1";
            pictureBoxForecastHour1.Size = new Size(50, 40);
            pictureBoxForecastHour1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxForecastHour1.TabIndex = 79;
            pictureBoxForecastHour1.TabStop = false;
            pictureBoxForecastHour1.Click += pictureBox16_Click;
            // 
            // labelForecastHour6
            // 
            labelForecastHour6.AutoSize = true;
            labelForecastHour6.BackColor = Color.LightSkyBlue;
            labelForecastHour6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelForecastHour6.Location = new Point(542, 36);
            labelForecastHour6.Name = "labelForecastHour6";
            labelForecastHour6.Size = new Size(50, 21);
            labelForecastHour6.TabIndex = 77;
            labelForecastHour6.Text = "15:00";
            // 
            // labelForecastHour5
            // 
            labelForecastHour5.AutoSize = true;
            labelForecastHour5.BackColor = Color.LightSkyBlue;
            labelForecastHour5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelForecastHour5.Location = new Point(433, 36);
            labelForecastHour5.Name = "labelForecastHour5";
            labelForecastHour5.Size = new Size(50, 21);
            labelForecastHour5.TabIndex = 76;
            labelForecastHour5.Text = "12:00";
            // 
            // labelForecastHour4
            // 
            labelForecastHour4.AutoSize = true;
            labelForecastHour4.BackColor = Color.LightSkyBlue;
            labelForecastHour4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelForecastHour4.Location = new Point(330, 36);
            labelForecastHour4.Name = "labelForecastHour4";
            labelForecastHour4.Size = new Size(41, 21);
            labelForecastHour4.TabIndex = 75;
            labelForecastHour4.Text = "9:00";
            // 
            // labelForecastHour3
            // 
            labelForecastHour3.AutoSize = true;
            labelForecastHour3.BackColor = Color.LightSkyBlue;
            labelForecastHour3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelForecastHour3.Location = new Point(224, 36);
            labelForecastHour3.Name = "labelForecastHour3";
            labelForecastHour3.Size = new Size(41, 21);
            labelForecastHour3.TabIndex = 74;
            labelForecastHour3.Text = "6:00";
            labelForecastHour3.Click += labelForecastHour3_Click;
            // 
            // labelForecastHour2
            // 
            labelForecastHour2.AutoSize = true;
            labelForecastHour2.BackColor = Color.LightSkyBlue;
            labelForecastHour2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelForecastHour2.Location = new Point(118, 36);
            labelForecastHour2.Name = "labelForecastHour2";
            labelForecastHour2.Size = new Size(41, 21);
            labelForecastHour2.TabIndex = 73;
            labelForecastHour2.Text = "3:00";
            labelForecastHour2.Click += label21_Click;
            // 
            // labelForecastHour1
            // 
            labelForecastHour1.AutoSize = true;
            labelForecastHour1.BackColor = Color.LightSkyBlue;
            labelForecastHour1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelForecastHour1.Location = new Point(20, 36);
            labelForecastHour1.Name = "labelForecastHour1";
            labelForecastHour1.Size = new Size(50, 21);
            labelForecastHour1.TabIndex = 72;
            labelForecastHour1.Text = "12:00";
            labelForecastHour1.Click += label22_Click;
            // 
            // groupBoxWeeklyForecast
            // 
            groupBoxWeeklyForecast.AutoSize = true;
            groupBoxWeeklyForecast.BackColor = Color.Transparent;
            groupBoxWeeklyForecast.BackgroundImageLayout = ImageLayout.Zoom;
            groupBoxWeeklyForecast.Controls.Add(HourlyDesc2);
            groupBoxWeeklyForecast.Controls.Add(HourlyDesc6);
            groupBoxWeeklyForecast.Controls.Add(HourlyDesc5);
            groupBoxWeeklyForecast.Controls.Add(HourlyDesc4);
            groupBoxWeeklyForecast.Controls.Add(HourlyDesc3);
            groupBoxWeeklyForecast.Controls.Add(HourlyDesc1);
            groupBoxWeeklyForecast.Controls.Add(HourlyTemp6);
            groupBoxWeeklyForecast.Controls.Add(HourlyTemp5);
            groupBoxWeeklyForecast.Controls.Add(HourlyTemp4);
            groupBoxWeeklyForecast.Controls.Add(HourlyTemp3);
            groupBoxWeeklyForecast.Controls.Add(HourlyTemp2);
            groupBoxWeeklyForecast.Controls.Add(HourlyTemp1);
            groupBoxWeeklyForecast.Controls.Add(pictureBoxForecastHour5);
            groupBoxWeeklyForecast.Controls.Add(labelForecastHour1);
            groupBoxWeeklyForecast.Controls.Add(labelForecastHour2);
            groupBoxWeeklyForecast.Controls.Add(labelForecastHour3);
            groupBoxWeeklyForecast.Controls.Add(labelForecastHour4);
            groupBoxWeeklyForecast.Controls.Add(labelForecastHour5);
            groupBoxWeeklyForecast.Controls.Add(labelForecastHour6);
            groupBoxWeeklyForecast.Controls.Add(pictureBoxForecastHour1);
            groupBoxWeeklyForecast.Controls.Add(pictureBoxForecastHour2);
            groupBoxWeeklyForecast.Controls.Add(pictureBoxForecastHour3);
            groupBoxWeeklyForecast.Controls.Add(pictureBoxForecastHour4);
            groupBoxWeeklyForecast.Controls.Add(pictureBoxForecastHour6);
            groupBoxWeeklyForecast.Location = new Point(177, 258);
            groupBoxWeeklyForecast.Name = "groupBoxWeeklyForecast";
            groupBoxWeeklyForecast.Size = new Size(634, 191);
            groupBoxWeeklyForecast.TabIndex = 56;
            groupBoxWeeklyForecast.TabStop = false;
            groupBoxWeeklyForecast.Text = "Hourly Forecast";
            groupBoxWeeklyForecast.Enter += groupBox1_Enter;
            // 
            // HourlyDesc2
            // 
            HourlyDesc2.BackColor = Color.Transparent;
            HourlyDesc2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            HourlyDesc2.ForeColor = Color.Black;
            HourlyDesc2.Location = new Point(118, 149);
            HourlyDesc2.Name = "HourlyDesc2";
            HourlyDesc2.Size = new Size(78, 23);
            HourlyDesc2.TabIndex = 97;
            HourlyDesc2.Text = "Clouds";
            // 
            // HourlyDesc6
            // 
            HourlyDesc6.BackColor = Color.Transparent;
            HourlyDesc6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            HourlyDesc6.ForeColor = Color.Black;
            HourlyDesc6.Location = new Point(533, 149);
            HourlyDesc6.Name = "HourlyDesc6";
            HourlyDesc6.Size = new Size(78, 23);
            HourlyDesc6.TabIndex = 96;
            HourlyDesc6.Text = "Clouds";
            // 
            // HourlyDesc5
            // 
            HourlyDesc5.BackColor = Color.Transparent;
            HourlyDesc5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            HourlyDesc5.ForeColor = Color.Black;
            HourlyDesc5.Location = new Point(433, 149);
            HourlyDesc5.Name = "HourlyDesc5";
            HourlyDesc5.Size = new Size(78, 23);
            HourlyDesc5.TabIndex = 95;
            HourlyDesc5.Text = "Clouds";
            HourlyDesc5.Click += label5_Click_2;
            // 
            // HourlyDesc4
            // 
            HourlyDesc4.BackColor = Color.Transparent;
            HourlyDesc4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            HourlyDesc4.ForeColor = Color.Black;
            HourlyDesc4.Location = new Point(330, 149);
            HourlyDesc4.Name = "HourlyDesc4";
            HourlyDesc4.Size = new Size(78, 23);
            HourlyDesc4.TabIndex = 94;
            HourlyDesc4.Text = "Clouds";
            // 
            // HourlyDesc3
            // 
            HourlyDesc3.BackColor = Color.Transparent;
            HourlyDesc3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            HourlyDesc3.ForeColor = Color.Black;
            HourlyDesc3.Location = new Point(224, 149);
            HourlyDesc3.Name = "HourlyDesc3";
            HourlyDesc3.Size = new Size(78, 23);
            HourlyDesc3.TabIndex = 93;
            HourlyDesc3.Text = "Clouds";
            // 
            // HourlyDesc1
            // 
            HourlyDesc1.AutoSize = true;
            HourlyDesc1.BackColor = Color.Transparent;
            HourlyDesc1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            HourlyDesc1.ForeColor = Color.Black;
            HourlyDesc1.Location = new Point(20, 149);
            HourlyDesc1.Name = "HourlyDesc1";
            HourlyDesc1.Size = new Size(43, 15);
            HourlyDesc1.TabIndex = 92;
            HourlyDesc1.Text = "Clouds";
            // 
            // HourlyTemp6
            // 
            HourlyTemp6.BackColor = Color.Transparent;
            HourlyTemp6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            HourlyTemp6.ForeColor = Color.Black;
            HourlyTemp6.Location = new Point(542, 119);
            HourlyTemp6.Name = "HourlyTemp6";
            HourlyTemp6.Size = new Size(50, 20);
            HourlyTemp6.TabIndex = 91;
            HourlyTemp6.Text = "105°C";
            HourlyTemp6.Click += HourlyTemp6_Click;
            // 
            // HourlyTemp5
            // 
            HourlyTemp5.BackColor = Color.Transparent;
            HourlyTemp5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            HourlyTemp5.ForeColor = Color.Black;
            HourlyTemp5.Location = new Point(433, 119);
            HourlyTemp5.Name = "HourlyTemp5";
            HourlyTemp5.Size = new Size(50, 20);
            HourlyTemp5.TabIndex = 90;
            HourlyTemp5.Text = "105°C";
            HourlyTemp5.Click += HourlyTemp5_Click;
            // 
            // HourlyTemp4
            // 
            HourlyTemp4.BackColor = Color.Transparent;
            HourlyTemp4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            HourlyTemp4.ForeColor = Color.Black;
            HourlyTemp4.Location = new Point(330, 119);
            HourlyTemp4.Name = "HourlyTemp4";
            HourlyTemp4.Size = new Size(50, 20);
            HourlyTemp4.TabIndex = 89;
            HourlyTemp4.Text = "105°C";
            // 
            // HourlyTemp3
            // 
            HourlyTemp3.BackColor = Color.Transparent;
            HourlyTemp3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            HourlyTemp3.ForeColor = Color.Black;
            HourlyTemp3.Location = new Point(222, 119);
            HourlyTemp3.Name = "HourlyTemp3";
            HourlyTemp3.Size = new Size(50, 20);
            HourlyTemp3.TabIndex = 88;
            HourlyTemp3.Text = "105°C";
            HourlyTemp3.Click += HourlyTemp3_Click;
            // 
            // HourlyTemp2
            // 
            HourlyTemp2.BackColor = Color.Transparent;
            HourlyTemp2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            HourlyTemp2.ForeColor = Color.Black;
            HourlyTemp2.Location = new Point(122, 119);
            HourlyTemp2.Name = "HourlyTemp2";
            HourlyTemp2.Size = new Size(50, 20);
            HourlyTemp2.TabIndex = 87;
            HourlyTemp2.Text = "105°C";
            // 
            // HourlyTemp1
            // 
            HourlyTemp1.BackColor = Color.Transparent;
            HourlyTemp1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            HourlyTemp1.ForeColor = Color.Black;
            HourlyTemp1.Location = new Point(24, 119);
            HourlyTemp1.Name = "HourlyTemp1";
            HourlyTemp1.Size = new Size(46, 20);
            HourlyTemp1.TabIndex = 86;
            HourlyTemp1.Text = "105°C";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(883, 586);
            Controls.Add(labelMoonset);
            Controls.Add(pictureBox1);
            Controls.Add(labelMoonrise);
            Controls.Add(pictureBox15);
            Controls.Add(groupBoxWeeklyForecast);
            Controls.Add(labelCurrentDateTime);
            Controls.Add(labelVisibility);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(labelHumidity);
            Controls.Add(pictureBox3);
            Controls.Add(labelPressure);
            Controls.Add(pictureBox2);
            Controls.Add(labelWind);
            Controls.Add(labelSunset);
            Controls.Add(pictureBox10);
            Controls.Add(labelSunrise);
            Controls.Add(pictureBox9);
            Controls.Add(labelTempInfo);
            Controls.Add(labelLowTemp);
            Controls.Add(label2);
            Controls.Add(labelHighTemp);
            Controls.Add(weatherIcon);
            Controls.Add(labelTemp);
            Controls.Add(labelCityName);
            Controls.Add(textBoxSearchCity);
            Controls.Add(searchButton);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Weather Forecast";
            TransparencyKey = Color.Transparent;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)weatherIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForecastHour6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForecastHour5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForecastHour4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForecastHour3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForecastHour2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForecastHour1).EndInit();
            groupBoxWeeklyForecast.ResumeLayout(false);
            groupBoxWeeklyForecast.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private ComboBox comboBox1;
        private GroupBox groupBoxWeeklyForecast;
        private Label labelLowTemp7;
        private Label labelLowTemp6;
        private Label labelLowTemp5;
        private Label label29;
        private Label labelLowTemp4;
        private Label label31;
        private Label labelLowTemp3;
        private Label label33;
        private Label labelLowTemp2;
        private Label label35;
        private Label label37;
        private PictureBox pictureBoxDay7;
        private PictureBox pictureBoxDay6;
        private PictureBox pictureBoxDay5;
        private PictureBox pictureBoxDay4;
        private PictureBox pictureBoxDay3;
        private Label labelMoonset;
        private PictureBox pictureBox1;
        private Label labelMoonrise;
        private PictureBox pictureBox15;
        public Label labelCityName;
        public Label labelTemp;
        public Label labelTempInfo;
        public PictureBox weatherIcon;
        public Label labelHighTemp;
        public Label labelLowTemp;
        public PictureBox pictureBox9;
        public Label labelSunrise;
        public PictureBox pictureBox10;
        public Label labelSunset;
        public Label labelWind;
        public Label labelPressure;
        public Label labelHumidity;
        public Label labelVisibility;
        private Label labelHighTemp7;
        private Label labelHighTemp6;
        private Label labelHighTemp5;
        private Label labelHighTemp4;
        private Label labelHighTemp3;
        private Label labelHighTemp2;
        public Label labelHighTemp1;
        public Label labelDay1;
        public Label labelDay2;
        public Label labelDay3;
        public Label labelDay4;
        public Label labelDay5;
        public Label labelDay6;
        public Label labelDay7;
        public Label labelLowTemp1;
        public PictureBox pictureBoxDay2;
        public PictureBox pictureBoxDay1;
        private PictureBox pictureBoxForecastHour6;
        private PictureBox pictureBoxForecastHour5;
        private PictureBox pictureBoxForecastHour4;
        private PictureBox pictureBoxForecastHour3;
        public PictureBox pictureBoxForecastHour2;
        public PictureBox pictureBoxForecastHour1;
        public Label labelForecastHour6;
        public Label labelForecastHour5;
        public Label labelForecastHour4;
        public Label labelForecastHour3;
        public Label labelForecastHour2;
        public Label labelForecastHour1;
        public Label HourlyTemp6;
        public Label HourlyTemp5;
        public Label HourlyTemp4;
        public Label HourlyTemp3;
        public Label HourlyTemp2;
        public Label HourlyTemp1;
        public Button searchButton;
        public TextBox textBoxSearchCity;
        public Label labelCurrentDateTime;
        public Label HourlyDesc6;
        public Label HourlyDesc5;
        public Label HourlyDesc4;
        public Label HourlyDesc3;
        public Label HourlyDesc1;
        public Label HourlyDesc2;
    }
}