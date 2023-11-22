using Assignment___Weather_Forecast.DataModels;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Assignment___Weather_Forecast.Adapters
{
    public class WeatherDataAdaptee
    {
        public Form1 mainForm;

        public WeatherDataAdaptee(Form1 mainForm)
        {
            this.mainForm = mainForm;
        }
        // ProcessWeatherData method updates the mainForm UI with the provided weatherData.
        public async void ProcessWeatherData(WeatherData weatherData)
        {
            // Set the current date and time on the UI.
            mainForm.labelCurrentDateTime.Text = DateTime.Now.ToString("MMMM dd,  HH:mm tt");
            
            // Convert temperature values to doubles for display.
            double temp = Convert.ToInt64(Math.Round(Convert.ToDouble(weatherData.Temperature)));
            double highTemp = Convert.ToInt64(Math.Round(Convert.ToDouble(weatherData.HighTemperature)));
            double lowTemp = Convert.ToInt64(Math.Round(Convert.ToDouble(weatherData.LowTemperature)));
            
            // Construct the URL for the weather icon.
            string iconUrl = $"http://openweathermap.org/img/w/{weatherData.Icon}.png";

            // Format sunrise and sunset times.
            string sunriseTimeString = weatherData.Sunrise.ToString("hh:mm tt");
            string sunsetTimeString = weatherData.Sunset.ToString("hh:mm tt");

            // Convert visibility to kilometers.
            double visibilityKilometers = weatherData.Visibility / 1000.0;


            System.Diagnostics.Debug.WriteLine(weatherData.foreCastData);
            System.Diagnostics.Debug.WriteLine(weatherData.Temperature);
            System.Diagnostics.Debug.WriteLine(temp);

            // Update mainForm UI with weather information.
            mainForm.labelCityName.Text = weatherData.Location + ',' + ' ' + weatherData.CountryName;
            mainForm.labelTemp.Text = temp.ToString() + "\u00B0C";

            // Download and display the weather icon.
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    // Download the image from the URL as a byte array.
                    byte[] imageBytes = await httpClient.GetByteArrayAsync(iconUrl);

                    // Convert the downloaded bytes to an image.
                    using (MemoryStream stream = new MemoryStream(imageBytes))
                    {
                        mainForm.weatherIcon.Image = Image.FromStream(stream);
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions, e.g., log an error.
                    Console.WriteLine($"Error downloading image: {ex.Message}");
                }
            }

            // Update additional weather information on the mainForm.
            mainForm.labelTempInfo.Text = "Feels like" + ' ' + weatherData.FeelsLikeTemp + "\u00B0C" + ". " + weatherData.Description; mainForm.labelTempInfo.Text = "Feels like" + ' ' + weatherData.FeelsLikeTemp + "\u00B0C" + ". " + weatherData.Description;
            mainForm.labelHighTemp.Text = "High:" + ' ' + highTemp.ToString() + "\u00B0C";
            mainForm.labelLowTemp.Text = "Low:" + ' ' + lowTemp.ToString() + "\u00B0C";
            mainForm.labelSunrise.Text = sunriseTimeString;
            mainForm.labelSunset.Text = sunsetTimeString;
            mainForm.labelWind.Text = weatherData.WindSpeed + "m/s WSW";
            mainForm.labelPressure.Text = weatherData.Pressure + "hPa";
            mainForm.labelHumidity.Text = weatherData.Humidity + "%";
            mainForm.labelVisibility.Text = visibilityKilometers.ToString("0.00") + " km";

            // Update hourly forecast information on the mainForm.
            for (int i = 0; i < Math.Min(weatherData.foreCastData.Count, 6); i++)
            {
                var forecast = weatherData.foreCastData[i];

                // Get the corresponding controls for the current hour
                var labelHour = mainForm.Controls.Find($"labelForecastHour{i + 1}", true).FirstOrDefault() as Label;
                var pictureBoxHour = mainForm.Controls.Find($"pictureBoxForecastHour{i + 1}", true).FirstOrDefault() as PictureBox;
                var labelTempHourly = mainForm.Controls.Find($"hourlyTemp{i + 1}", true).FirstOrDefault() as Label;
                var labelDescHourly = mainForm.Controls.Find($"hourlyDesc{i + 1}", true).FirstOrDefault() as Label;


                double forecastTemp = Convert.ToInt64(Math.Round(Convert.ToDouble(forecast.temp)));
                
                // Update hourly forecast information on the mainForm.
                if (labelHour != null && pictureBoxHour != null && labelTempHourly != null && labelDescHourly != null)
                {
                    // Update hour label
                    System.Diagnostics.Debug.WriteLine("po");
                    labelHour.Text = forecast.date.ToString("h:mm tt");

                    // Update forecast data
                    LoadAndDisplayIcon(forecast.icon, pictureBoxHour);
                    labelTempHourly.Text = forecastTemp + "\u00B0C";

                    // Capitalize the text using TextInfo.ToTitleCase
                    string capitalizedDesc = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(forecast.WeatherDescription.ToLower());

                    // Update the label with the capitalized text
                    labelDescHourly.Text = capitalizedDesc;
                }
            }
        }

        // LoadAndDisplayIcon method downloads and displays the weather icon.
        private async void LoadAndDisplayIcon(string icon, PictureBox pictureBox)
        {
            // Construct the URL for the weather icon.
            string iconUrl = $"http://openweathermap.org/img/w/{icon}.png";

            // Use the HttpClient to download the image from the URL.
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    // Download the image from the URL as a byte array.
                    byte[] imageBytes = await httpClient.GetByteArrayAsync(iconUrl);

                    // Convert the downloaded bytes to an image.
                    using (MemoryStream stream = new MemoryStream(imageBytes))
                    {
                        pictureBox.Image = Image.FromStream(stream);
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions, e.g., log an error.
                    Console.WriteLine($"Error downloading image: {ex.Message}");
                }
            }
        }
    }
}
