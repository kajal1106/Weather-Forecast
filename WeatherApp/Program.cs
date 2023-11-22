using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;

namespace Assignment___Weather_Forecast
{
    internal static class Program
    {
        [STAThread]
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string apiKey = "d4e611667c168e673ff781c5e9282c80"; // Replace with your OpenWeatherMap API key
            string city = "Athlone"; // Replace with your desired city

            string weatherApiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={apiKey}";
            string forecastApiUrl = $"https://api.openweathermap.org/data/2.5/forecast?q={city}&units=metric&appid={apiKey}&cnt=7";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(weatherApiUrl);
                    HttpResponseMessage response2 = await client.GetAsync(forecastApiUrl);

                    if (response.IsSuccessStatusCode && response2.IsSuccessStatusCode)
                    {
                        string weatherJson = await response.Content.ReadAsStringAsync();
                        string forecastJson = await response2.Content.ReadAsStringAsync();

                        JObject weatherObj = JObject.Parse(weatherJson);
                        JObject forecastObj = JObject.Parse(forecastJson);

                        Form1 mainForm = new Form1(); // Create an instance of Form1

                        // Pass the Form1 instance to the IWeatherDataAdapter constructor
                        IWeatherDataAdapter weatherDataAdapter = new IWeatherDataAdapter(mainForm);

                        weatherDataAdapter.ProcessWeather(weatherObj, forecastObj);

                        Application.Run(mainForm);
                    }
                    else
                    {
                        Console.WriteLine($"API request failed. Status code: {response.StatusCode}");
                        System.Diagnostics.Debug.WriteLine($"API request failed. Status code: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
