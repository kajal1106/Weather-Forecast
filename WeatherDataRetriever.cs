using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Assignment___Weather_Forecast
{
    public class WeatherDataRetriever
    {
        private readonly string apiKey;
        private readonly HttpClient httpClient;

        public WeatherDataRetriever(string apiKey)
        {
            this.apiKey = apiKey;
            httpClient = new HttpClient();
        }

        public async Task<string> GetWeatherDataAsync(string city)
        {
            string weatherApiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={apiKey}";
            string forecastApiUrl = $"https://api.openweathermap.org/data/2.5/forecast?q={city}&units=metric&appid={apiKey}&cnt=7";

            try
            {
                //string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={apiKey}";
                HttpResponseMessage response = await httpClient.GetAsync(weatherApiUrl);
                HttpResponseMessage response2 = await httpClient.GetAsync(forecastApiUrl);

                if (response.IsSuccessStatusCode && response2.IsSuccessStatusCode)
                {
                    string weatherJson = await response.Content.ReadAsStringAsync();
                    string forecastJson = await response2.Content.ReadAsStringAsync();
                    Tuple<string, string> t = new Tuple<string, string>(weatherJson, forecastJson);

                    JObject weatherObj = JObject.Parse(weatherJson);
                    JObject forecastObj = JObject.Parse(forecastJson);
                    return t;
                }
                else
                {
                    Console.WriteLine($"API request failed. Status code: {response.StatusCode}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
    }
}