# Weather Forecast Application using Adapter Pattern

## Overview

This C# application provides users with real-time weather forecast information for a specified city, utilizing the Adapter Pattern to seamlessly integrate weather data from the OpenWeatherMap API into the application.

## Table of Contents

- [Objective](#objective)
- [Design Pattern](#design-pattern)
- [Project Scope](#project-scope)
- [Adapter Pattern Implementation](#adapter-pattern-implementation)
- [GUI Front-End](#gui-front-end)
- [Conclusion](#conclusion)
- [References](#references)
- [Installation Instructions](#installation-instructions)

## Objective

The primary goal of this project is to develop a C# application with a graphical user interface (GUI) that provides users with real-time weather forecast information for a specified city. The key emphasis is on utilizing the Adapter Pattern to seamlessly integrate weather data from the OpenWeatherMap API into the application.

## Design Pattern

The project's design heavily relies on the Adapter Pattern to facilitate the integration and transformation of data from an external API into a format suitable for the application.

## Project Scope

### Functionality

The application enables users to input a city name, fetches up-to-the-minute weather data from the OpenWeatherMap API, and exhibits the current weather conditions. Additionally, it provides a 6-hour forecast. The Adapter Pattern is employed to adapt the API response to meet the application's specific requirements.

### Adapter Pattern Implementation

#### Design Overview

The Adapter Pattern is implemented to act as an intermediary between the application and the OpenWeatherMap API. This ensures that the application can seamlessly consume and display the weather data.

#### Code Explanation

- **IWeatherData Interface:** The `IWeatherData` interface outlines the contract for processing weather data. The method `ProcessWeather` takes two `JObject` parameters, `weatherObj` and `forecastObj`, representing the current weather and forecast data, respectively.

- **WeatherDataAdaptee Class:** The `WeatherDataAdaptee` class acts as a bridge between the processed weather data and the GUI, updating various elements dynamically based on the provided data. The `ProcessWeatherData` method handles the integration of current weather and forecast data into the application's GUI.

- **IWeatherDataAdapter Class:** The `IWeatherDataAdapter` class implements the `IWeatherData` interface, responsible for adapting the API response and invoking the `WeatherDataAdaptee` to update the GUI. The `ProcessWeather` method orchestrates the adaptation process.

### GUI Front-End

#### User Interface

The GUI is designed with input fields for users to enter the city name, and it dynamically updates to display the real-time temperature and hourly forecasts.

#### Dynamic Features

Screenshots showcase the GUI, highlighting the dynamic elements, such as real-time temperature updates and hourly forecast displays.
![image](https://github.com/kajal1106/Assignment---Weather-Forecast/assets/39821430/fde485c0-b418-499c-92f6-7d0dc9eee351)

The initial page has a default set of data for Athlone, IE, and users can use the search functionality to get weather information for their desired city.

![image](https://github.com/kajal1106/Assignment---Weather-Forecast/assets/39821430/1b425ce3-a30a-4a81-9853-406438b8d400)

Fig: GUI of city info when a user searches the desired city name

## Conclusion

In conclusion, the implemented Adapter Pattern serves as a robust design choice to seamlessly integrate weather data from the OpenWeatherMap API into the C# application. The modular structure of the pattern allows for flexibility and ease of maintenance. By adhering to the principles of the Adapter Pattern, the application achieves a clean separation of concerns, making it more adaptable to future changes or enhancements.

The GUI front-end provides users with an intuitive and interactive experience. With features like real-time temperature updates, hourly forecasts, and error handling, the application ensures a user-friendly interface. By default, the application displays weather information for Athlone, IE, providing immediate insights upon launch. The inclusion of a search functionality allows users to explore weather data for their desired city effortlessly.

## References

The successful completion of this project was made possible with the guidance and utilization of various resources. The following references were instrumental in the design, implementation, and documentation of the C# weather forecast application:

- **Official Documentation:**
  - [C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
  - [OpenWeatherMap API Documentation](https://openweathermap.org/api)
  - [Newtonsoft.Json Documentation](https://www.newtonsoft.com/json)

- **Tutorials and Guides:**
  - [Adapter Pattern Tutorial](https://refactoring.guru/design-patterns/adapter)
  - [C# GUI Programming with Windows Forms](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-6.0)

- **Community Support and Forums:**
  - [Stack Overflow C# Community](https://stackoverflow.com/questions)
  - [OpenWeatherMap Community Forums](https://openweathermap.org/forum)

These references provided valuable insights, code samples, and community support, contributing to the successful development of the weather forecast application.

## Installation Instructions

To run the Weather Forecast Application locally, follow these steps:

### Prerequisites

Before you begin, ensure you have the following installed on your machine:

- [.NET SDK](https://dotnet.microsoft.com/download) - Make sure to install the appropriate version for your operating system.

### Clone the Repository

```bash
git clone https://github.com/kajal1106/Assignment---Weather-Forecast.git

