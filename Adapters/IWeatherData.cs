using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___Weather_Forecast.Adapters
{
    // IWeatherData interface defines a contract for processing weather data.
    public interface IWeatherData
    {
        // ProcessWeather method is responsible for handling weather data and updating the UI.
        // It takes JObject instances representing the current weather and forecast as parameters.
        void ProcessWeather(JObject weatherObj, JObject forecastObj);
    }
}
