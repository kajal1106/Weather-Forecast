using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___Weather_Forecast.DataModels
{
    // ForecastData class represents data for a single forecast entry.
    public class ForecastData
    {
        // Constructor initializes the ForecastData object with specific properties.
        public ForecastData(DateTime date, string temp, string weatherDescription, string highTemp, string lowTemp, string icon)
        {
            this.date = date;
            this.temp = temp;
            WeatherDescription = weatherDescription;
            this.highTemp = highTemp;
            LowTemp = lowTemp;
            this.icon = icon;
        }

        public DateTime date { get; set; }

        public string temp { get; set; }
        public string WeatherDescription { get; set; }
        public string highTemp { get; set; }
        public string LowTemp { get; set; }
        public string icon { get; set; }

    }
    // WeatherData class represents the main weather data including the current weather and forecast.
    public class WeatherData
    {
        // Constructor initializes the WeatherData object with specific properties.
        public WeatherData(string location, string countryName, string temperature, string feelsLikeTemp, string icon, string description, double windSpeed, double pressure, int humidity, double visibility, DateTime sunrise, DateTime sunset, string highTemperature, string lowTemperature, List<ForecastData> foreCastDatalist)
        {
            Location = location;
            CountryName = countryName;
            Temperature = temperature;
            FeelsLikeTemp = feelsLikeTemp;
            Description = description;
            Icon = icon;
            WindSpeed = windSpeed;
            Pressure = pressure;
            Humidity = humidity;
            Visibility = visibility;
            Sunrise = sunrise;
            Sunset = sunset;
            HighTemperature = highTemperature;
            LowTemperature = lowTemperature;
            foreCastData = foreCastDatalist;
        }

        public string Location { get; set; }
        public string CountryName { get; set; }
        public string Temperature { get; set; }
        public string FeelsLikeTemp { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public double WindSpeed { get; set; }
        public double Pressure { get; set; }
        public int Humidity { get; set; }
        public double Visibility { get; set; }
        public DateTime Sunrise { get; set; }
        public DateTime Sunset { get; set; }
        public DateTime Moonrise { get; set; }
        public DateTime Moonset { get; set; }
        public string HighTemperature { get; set; }
        public string LowTemperature { get; set; }
        public List<ForecastData> foreCastData { get; set; }

    }
}
