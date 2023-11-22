using Assignment___Weather_Forecast.DataModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment___Weather_Forecast.Adapters
{
    public class IWeatherDataAdapter : IWeatherData
    {
        WeatherDataAdaptee weatherDataAdaptee;

        // Constructor to initialize the WeatherDataAdaptee with the mainForm instance.
        public IWeatherDataAdapter(Form1 mainForm)
        {
            weatherDataAdaptee = new WeatherDataAdaptee(mainForm);
        }

        // ProcessWeather method processes JSON data to create WeatherData objects.
        // It uses Newtonsoft.Json to parse the JSON data.
        public void ProcessWeather(JObject weatherObj, JObject forecastObj)
        {
            // Extract basic weather information from the weatherObj.
            string location = (string)weatherObj["name"]!;
            string countryName = (string)weatherObj["sys"]!["country"]!;
            string temperature = (string)weatherObj["main"]!["temp"]!;
            string feelsLikeTemp = (string)weatherObj["main"]!["feels_like"]!;
            string description = (string)weatherObj["weather"]![0]!["description"]!;
            string icon = (string)weatherObj["weather"]![0]!["icon"]!;
            double windSpeed = (double)weatherObj["wind"]!["speed"]!;
            double pressure = (double)weatherObj["main"]!["pressure"]!;
            int humidity = (int)weatherObj["main"]!["humidity"]!;
            double visibility = (double)weatherObj["visibility"]!;
            DateTime sunrise = DateTimeOffset.FromUnixTimeSeconds((long)weatherObj["sys"]!["sunrise"]!).LocalDateTime;
            DateTime sunset = DateTimeOffset.FromUnixTimeSeconds((long)weatherObj["sys"]!["sunset"]!).LocalDateTime;
            string highTemperature = (string)weatherObj["main"]!["temp_max"]!;
            string lowTemperature = (string)weatherObj["main"]!["temp_min"]!;

            // Create a list to store forecast data.
            List<ForecastData> forecastDataList = new List<ForecastData>();
            int forecastDaysCount = 6;

            // Extract forecast information from the forecastObj.
            for (int i = 0; i < forecastDaysCount && i < forecastObj["list"]!.Count(); i++)
            {
                var item = forecastObj["list"]![i];
                DateTime date = DateTimeOffset.FromUnixTimeSeconds((long)item["dt"]!).LocalDateTime;
                string hourlyTemp = (string)item["main"]!["temp"]!;
                string forecastHighTemp = (string)item["main"]!["temp_max"]!;
                string forecastLowTemp = (string)item["main"]!["temp_min"]!;
                string forecastDesc = (string)item["weather"]![0]!["description"]!;
                string hourlyIcon = (string)item["weather"]![0]!["icon"]!;
                ForecastData forecastData = new ForecastData(date, hourlyTemp, forecastDesc, forecastHighTemp, forecastLowTemp, hourlyIcon);
                forecastDataList.Add(forecastData);
            }

            // Create a WeatherData object with the extracted information.
            WeatherData weatherData = new WeatherData(location, countryName, temperature, feelsLikeTemp, icon, description, windSpeed, pressure, humidity, visibility, sunrise, sunset, highTemperature, lowTemperature, forecastDataList);
            
            // Call the ProcessWeatherData method in the WeatherDataAdaptee to update the UI.
            weatherDataAdaptee.ProcessWeatherData(weatherData);
        }
    }
}
