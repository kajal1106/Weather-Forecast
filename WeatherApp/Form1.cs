using Assignment___Weather_Forecast.Adapters;
using Newtonsoft.Json.Linq;

namespace Assignment___Weather_Forecast
{
    public partial class Form1 : Form
    {
        // Instance of the WeatherDataAdaptee for processing weather data.
        private readonly WeatherDataAdaptee weatherDataAdaptee;
        
        // Static instance of Form1 for reference.
        public static Form1 gui;

        // Constructor for Form1.
        public Form1()
        {
            InitializeComponent();
            // Set the static instance of Form1 to the current instance.
            gui = this;
            // Initialize the WeatherDataAdaptee with the current form
            weatherDataAdaptee = new WeatherDataAdaptee(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Event handler for the searchButton Click event.
        private async void searchButton_Click(object sender, EventArgs e)
        {
            // Get the city name from the TextBox
            string cityName = textBoxSearchCity.Text;

            // Check if the city name is not empty
            if (!string.IsNullOrWhiteSpace(cityName))
            {
                // Call a method to fetch weather data for the entered city
                await FetchWeatherData(cityName);
            }
            else
            {
                // Display an error message or handle the case where the city name is empty
                MessageBox.Show("Please enter a city name.");
            }
        }

        // Method to fetch weather data for a given city.
        private async Task FetchWeatherData(string cityName)
        {
            string apiKey = "d4e611667c168e673ff781c5e9282c80"; // Replace with your OpenWeatherMap API key
            string city = "Athlone"; // Replace with your desired city

            // URLs for fetching current weather and forecast data.
            string weatherApiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&units=metric&appid={apiKey}";
            string forecastApiUrl = $"https://api.openweathermap.org/data/2.5/forecast?q={cityName}&units=metric&appid={apiKey}&cnt=7";

            try
            {
                // Use HttpClient to make asynchronous API requests.
                using (HttpClient client = new HttpClient())
                {
                    // Make API requests for current weather and forecast data.
                    HttpResponseMessage response = await client.GetAsync(weatherApiUrl);
                    HttpResponseMessage response2 = await client.GetAsync(forecastApiUrl);

                    // Check if both API requests are successful.
                    if (response.IsSuccessStatusCode && response2.IsSuccessStatusCode)
                    {
                        // Read the JSON responses.
                        string weatherJson = await response.Content.ReadAsStringAsync();
                        string forecastJson = await response2.Content.ReadAsStringAsync();

                        // Parse JSON responses into JObjects.
                        JObject weatherObj = JObject.Parse(weatherJson);
                        JObject forecastObj = JObject.Parse(forecastJson);

                        // Pass the Form1 instance to the IWeatherDataAdapter constructor
                        IWeatherDataAdapter weatherDataAdapter = new IWeatherDataAdapter(gui);

                        // Process weather data using the weatherDataAdapter.
                        weatherDataAdapter.ProcessWeather(weatherObj, forecastObj);
                    }
                    else
                    {
                        // Log an error message if API requests fail.
                        Console.WriteLine($"API request failed. Status code: {response.StatusCode}");
                        System.Diagnostics.Debug.WriteLine($"API request failed. Status code: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log an error message if an exception occurs during API requests.
                Console.WriteLine($"Error: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Error: {ex.Message}");
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelCityName_Click(object sender, EventArgs e)
        {

        }

        private void labelLowTemp_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {
        }

        private void weatherIcon_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxDay_Click(object sender, EventArgs e)
        {

        }

        private void labelHighTempWeekly_Click(object sender, EventArgs e)
        {
        }

        private void labelLowTempWeekly_Click(object sender, EventArgs e)
        {
        }

        private void label36_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox19_Click_1(object sender, EventArgs e)
        {
        }

        private void label38_Click_1(object sender, EventArgs e)
        {
        }

        private void label39_Click(object sender, EventArgs e)
        {
        }

        private void label34_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
        }

        private void label24_Click(object sender, EventArgs e)
        {
        }

        private void label23_Click(object sender, EventArgs e)
        {
        }

        private void label41_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
        }

        private void label40_Click(object sender, EventArgs e)
        {
        }

        private void label26_Click(object sender, EventArgs e)
        {
        }

        private void label44_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox20_Click_1(object sender, EventArgs e)
        {

        }

        private void labelLowTempWeekly_Click_1(object sender, EventArgs e)
        {
        }

        private void label23_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBox17_Click_1(object sender, EventArgs e)
        {
        }

        private void label24_Click_1(object sender, EventArgs e)
        {
        }

        private void label26_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBox19_Click_2(object sender, EventArgs e)
        {
        }

        private void label36_Click_1(object sender, EventArgs e)
        {
        }

        private void label44_Click_2(object sender, EventArgs e)
        {
        }

        private void label41_Click_1(object sender, EventArgs e)
        {
        }

        private void label34_Click_1(object sender, EventArgs e)
        {
        }

        private void label39_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBoxDay_Click_1(object sender, EventArgs e)
        {
        }

        private void label40_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBox21_Click_1(object sender, EventArgs e)
        {
        }

        private void labelHighTempWeekly_Click_1(object sender, EventArgs e)
        {
        }

        private void label38_Click_2(object sender, EventArgs e)
        {
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void label21_Click(object sender, EventArgs e)
        {
        }

        private void label22_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxForecastHour3_Click(object sender, EventArgs e)
        {

        }

        private void labelForecastHour3_Click(object sender, EventArgs e)
        {
        }

        private void HourlyTemp6_Click(object sender, EventArgs e)
        {

        }

        private void HourlyTemp5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxForecastHour5_Click(object sender, EventArgs e)
        {

        }

        private void HourlyTemp3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }
    }
}