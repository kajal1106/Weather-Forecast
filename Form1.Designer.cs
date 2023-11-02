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
            labelDateTime = new Label();
            comboBox1 = new ComboBox();
            groupBoxWeeklyForecast = new GroupBox();
            label1 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            label37 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            label38 = new Label();
            label39 = new Label();
            label40 = new Label();
            label41 = new Label();
            label42 = new Label();
            label43 = new Label();
            label44 = new Label();
            pictureBox15 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)weatherIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            groupBoxWeeklyForecast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Transparent;
            searchButton.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            searchButton.FlatAppearance.BorderSize = 2;
            searchButton.ForeColor = SystemColors.Desktop;
            searchButton.Location = new Point(486, 21);
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
            textBoxSearchCity.Enabled = false;
            textBoxSearchCity.Location = new Point(257, 22);
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
            labelCityName.Location = new Point(263, 59);
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
            labelTemp.Location = new Point(298, 99);
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
            weatherIcon.Location = new Point(269, 104);
            weatherIcon.Name = "weatherIcon";
            weatherIcon.Size = new Size(30, 20);
            weatherIcon.SizeMode = PictureBoxSizeMode.Zoom;
            weatherIcon.TabIndex = 5;
            weatherIcon.TabStop = false;
            weatherIcon.Click += weatherIcon_Click;
            // 
            // labelHighTemp
            // 
            labelHighTemp.BackColor = Color.Transparent;
            labelHighTemp.ForeColor = Color.Black;
            labelHighTemp.Location = new Point(269, 140);
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
            label2.Location = new Point(335, 140);
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
            labelLowTemp.Location = new Point(350, 140);
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
            labelTempInfo.Location = new Point(372, 104);
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
            pictureBox9.Location = new Point(269, 177);
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
            labelSunrise.Location = new Point(306, 181);
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
            pictureBox10.Location = new Point(372, 177);
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
            labelSunset.Location = new Point(415, 181);
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
            labelWind.Location = new Point(295, 218);
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
            pictureBox2.Location = new Point(269, 212);
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
            pictureBox3.Location = new Point(378, 212);
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
            labelPressure.Location = new Point(404, 218);
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
            pictureBox4.Location = new Point(460, 212);
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
            labelHumidity.Location = new Point(486, 218);
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
            pictureBox5.Location = new Point(528, 212);
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
            labelVisibility.Location = new Point(558, 218);
            labelVisibility.Name = "labelVisibility";
            labelVisibility.Size = new Size(45, 15);
            labelVisibility.TabIndex = 53;
            labelVisibility.Text = "10.0km";
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.BackColor = Color.Transparent;
            labelDateTime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelDateTime.ForeColor = Color.Red;
            labelDateTime.Location = new Point(752, 20);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(119, 21);
            labelDateTime.TabIndex = 54;
            labelDateTime.Text = "Nov 2, 12:17pm";
            labelDateTime.Click += label1_Click_3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "API 1", "API 2", "API 3" });
            comboBox1.Location = new Point(12, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 23);
            comboBox1.TabIndex = 55;
            comboBox1.Text = "Choose Weather Source";
            // 
            // groupBoxWeeklyForecast
            // 
            groupBoxWeeklyForecast.AutoSize = true;
            groupBoxWeeklyForecast.BackColor = Color.Transparent;
            groupBoxWeeklyForecast.BackgroundImageLayout = ImageLayout.Zoom;
            groupBoxWeeklyForecast.Controls.Add(label1);
            groupBoxWeeklyForecast.Controls.Add(label25);
            groupBoxWeeklyForecast.Controls.Add(label26);
            groupBoxWeeklyForecast.Controls.Add(label27);
            groupBoxWeeklyForecast.Controls.Add(label28);
            groupBoxWeeklyForecast.Controls.Add(label29);
            groupBoxWeeklyForecast.Controls.Add(label30);
            groupBoxWeeklyForecast.Controls.Add(label31);
            groupBoxWeeklyForecast.Controls.Add(label32);
            groupBoxWeeklyForecast.Controls.Add(label33);
            groupBoxWeeklyForecast.Controls.Add(label34);
            groupBoxWeeklyForecast.Controls.Add(label35);
            groupBoxWeeklyForecast.Controls.Add(label36);
            groupBoxWeeklyForecast.Controls.Add(label37);
            groupBoxWeeklyForecast.Controls.Add(pictureBox6);
            groupBoxWeeklyForecast.Controls.Add(pictureBox7);
            groupBoxWeeklyForecast.Controls.Add(pictureBox8);
            groupBoxWeeklyForecast.Controls.Add(pictureBox11);
            groupBoxWeeklyForecast.Controls.Add(pictureBox12);
            groupBoxWeeklyForecast.Controls.Add(pictureBox13);
            groupBoxWeeklyForecast.Controls.Add(pictureBox14);
            groupBoxWeeklyForecast.Controls.Add(label38);
            groupBoxWeeklyForecast.Controls.Add(label39);
            groupBoxWeeklyForecast.Controls.Add(label40);
            groupBoxWeeklyForecast.Controls.Add(label41);
            groupBoxWeeklyForecast.Controls.Add(label42);
            groupBoxWeeklyForecast.Controls.Add(label43);
            groupBoxWeeklyForecast.Controls.Add(label44);
            groupBoxWeeklyForecast.Location = new Point(257, 265);
            groupBoxWeeklyForecast.Name = "groupBoxWeeklyForecast";
            groupBoxWeeklyForecast.Size = new Size(466, 162);
            groupBoxWeeklyForecast.TabIndex = 56;
            groupBoxWeeklyForecast.TabStop = false;
            groupBoxWeeklyForecast.Text = "Weekly Forecast";
            groupBoxWeeklyForecast.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(401, 128);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 71;
            label1.Text = "L: 50°C";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.ForeColor = Color.Black;
            label25.Location = new Point(401, 104);
            label25.Name = "label25";
            label25.Size = new Size(53, 15);
            label25.TabIndex = 70;
            label25.Text = "H: 105°C";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.ForeColor = Color.Black;
            label26.Location = new Point(340, 128);
            label26.Name = "label26";
            label26.Size = new Size(44, 15);
            label26.TabIndex = 69;
            label26.Text = "L: 50°C";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.Transparent;
            label27.ForeColor = Color.Black;
            label27.Location = new Point(340, 104);
            label27.Name = "label27";
            label27.Size = new Size(53, 15);
            label27.TabIndex = 68;
            label27.Text = "H: 105°C";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.BackColor = Color.Transparent;
            label28.ForeColor = Color.Black;
            label28.Location = new Point(274, 128);
            label28.Name = "label28";
            label28.Size = new Size(44, 15);
            label28.TabIndex = 67;
            label28.Text = "L: 50°C";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = Color.Transparent;
            label29.ForeColor = Color.Black;
            label29.Location = new Point(274, 104);
            label29.Name = "label29";
            label29.Size = new Size(53, 15);
            label29.TabIndex = 66;
            label29.Text = "H: 105°C";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = Color.Transparent;
            label30.ForeColor = Color.Black;
            label30.Location = new Point(210, 128);
            label30.Name = "label30";
            label30.Size = new Size(44, 15);
            label30.TabIndex = 65;
            label30.Text = "L: 50°C";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.BackColor = Color.Transparent;
            label31.ForeColor = Color.Black;
            label31.Location = new Point(210, 104);
            label31.Name = "label31";
            label31.Size = new Size(53, 15);
            label31.TabIndex = 64;
            label31.Text = "H: 105°C";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.BackColor = Color.Transparent;
            label32.ForeColor = Color.Black;
            label32.Location = new Point(143, 128);
            label32.Name = "label32";
            label32.Size = new Size(44, 15);
            label32.TabIndex = 63;
            label32.Text = "L: 50°C";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.BackColor = Color.Transparent;
            label33.ForeColor = Color.Black;
            label33.Location = new Point(143, 104);
            label33.Name = "label33";
            label33.Size = new Size(53, 15);
            label33.TabIndex = 62;
            label33.Text = "H: 105°C";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.BackColor = Color.Transparent;
            label34.ForeColor = Color.Black;
            label34.Location = new Point(82, 128);
            label34.Name = "label34";
            label34.Size = new Size(44, 15);
            label34.TabIndex = 61;
            label34.Text = "L: 50°C";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.BackColor = Color.Transparent;
            label35.ForeColor = Color.Black;
            label35.Location = new Point(82, 104);
            label35.Name = "label35";
            label35.Size = new Size(53, 15);
            label35.TabIndex = 60;
            label35.Text = "H: 105°C";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.BackColor = Color.Transparent;
            label36.ForeColor = Color.Black;
            label36.Location = new Point(16, 128);
            label36.Name = "label36";
            label36.Size = new Size(44, 15);
            label36.TabIndex = 59;
            label36.Text = "L: 50°C";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.BackColor = Color.Transparent;
            label37.ForeColor = Color.Black;
            label37.Location = new Point(16, 104);
            label37.Name = "label37";
            label37.Size = new Size(53, 15);
            label37.TabIndex = 58;
            label37.Text = "H: 105°C";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Image = Properties.Resources.cloudy;
            pictureBox6.Location = new Point(401, 66);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(20, 20);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 57;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click_1;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Image = Properties.Resources.cloudy;
            pictureBox7.Location = new Point(338, 66);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(20, 20);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 56;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.Image = Properties.Resources.cloudy;
            pictureBox8.Location = new Point(281, 66);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(20, 20);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 55;
            pictureBox8.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.Transparent;
            pictureBox11.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox11.Image = Properties.Resources.cloudy;
            pictureBox11.Location = new Point(219, 66);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(20, 20);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 54;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.Transparent;
            pictureBox12.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox12.Image = Properties.Resources.cloudy;
            pictureBox12.Location = new Point(155, 66);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(20, 20);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 53;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.Transparent;
            pictureBox13.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox13.Image = Properties.Resources.cloudy;
            pictureBox13.Location = new Point(90, 66);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(20, 20);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 52;
            pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.BackColor = Color.Transparent;
            pictureBox14.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox14.Image = Properties.Resources.cloudy;
            pictureBox14.Location = new Point(30, 66);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(20, 20);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 51;
            pictureBox14.TabStop = false;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.BackColor = Color.LightSkyBlue;
            label38.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label38.Location = new Point(390, 32);
            label38.Name = "label38";
            label38.Size = new Size(44, 21);
            label38.TabIndex = 50;
            label38.Text = "SUN";
            label38.Click += label38_Click;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.BackColor = Color.LightSkyBlue;
            label39.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label39.Location = new Point(330, 32);
            label39.Name = "label39";
            label39.Size = new Size(38, 21);
            label39.TabIndex = 49;
            label39.Text = "SAT";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.BackColor = Color.LightSkyBlue;
            label40.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label40.Location = new Point(274, 32);
            label40.Name = "label40";
            label40.Size = new Size(33, 21);
            label40.TabIndex = 48;
            label40.Text = "FRI";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.BackColor = Color.LightSkyBlue;
            label41.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label41.Location = new Point(210, 32);
            label41.Name = "label41";
            label41.Size = new Size(43, 21);
            label41.TabIndex = 47;
            label41.Text = "THU";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.BackColor = Color.LightSkyBlue;
            label42.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label42.Location = new Point(143, 32);
            label42.Name = "label42";
            label42.Size = new Size(47, 21);
            label42.TabIndex = 46;
            label42.Text = "WED";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.BackColor = Color.LightSkyBlue;
            label43.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label43.Location = new Point(82, 32);
            label43.Name = "label43";
            label43.Size = new Size(40, 21);
            label43.TabIndex = 45;
            label43.Text = "TUE";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.BackColor = Color.LightSkyBlue;
            label44.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label44.Location = new Point(16, 32);
            label44.Name = "label44";
            label44.Size = new Size(50, 21);
            label44.TabIndex = 44;
            label44.Text = "MON";
            // 
            // pictureBox15
            // 
            pictureBox15.BackColor = Color.Transparent;
            pictureBox15.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox15.Image = (Image)resources.GetObject("pictureBox15.Image");
            pictureBox15.Location = new Point(12, 65);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(24, 24);
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox15.TabIndex = 43;
            pictureBox15.TabStop = false;
            pictureBox15.UseWaitCursor = true;
            pictureBox15.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(883, 590);
            Controls.Add(groupBoxWeeklyForecast);
            Controls.Add(comboBox1);
            Controls.Add(labelDateTime);
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
            Controls.Add(pictureBox15);
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
            groupBoxWeeklyForecast.ResumeLayout(false);
            groupBoxWeeklyForecast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button searchButton;
        private TextBox textBoxSearchCity;
        private Label labelCityName;
        private Label labelTemp;
        private PictureBox weatherIcon;
        private Label labelHighTemp;
        private Label label2;
        private Label labelLowTemp;
        private Label labelTempInfo;
        private PictureBox pictureBox9;
        private Label labelSunrise;
        private PictureBox pictureBox10;
        private Label labelSunset;
        private Label labelWind;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label labelPressure;
        private PictureBox pictureBox4;
        private Label labelHumidity;
        private PictureBox pictureBox5;
        private Label labelVisibility;
        private Label labelDateTime;
        private ComboBox comboBox1;
        private GroupBox groupBoxWeeklyForecast;
        private Label label1;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private Label label38;
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label44;
        private PictureBox pictureBox15;
    }
}