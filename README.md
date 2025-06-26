# WeatherApp
Sure! Here’s the full README.md content without the license section, ready for you to copy-paste directly:

````
# WeatherApp (.NET Console)

A simple and minimalistic .NET 6 console application that fetches real-time weather data using the [OpenWeatherMap API](https://openweathermap.org/api).

---

## Features

- Real-time weather by city name  
- Displays temperature (°C), weather condition, and "feels like" temperature  
- Uses `HttpClient` for HTTP requests and `System.Text.Json` for JSON parsing  
- Lightweight and easy to understand, perfect for learning API consumption in .NET  

---

## Prerequisites

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download) installed on your machine  
- A free API key from [OpenWeatherMap](https://openweathermap.org/api) (sign up for a free account)  

---

## Getting Started

1. **Clone the repository:**

   ```bash
   git clone https://github.com/yourusername/WeatherApp.git
   cd WeatherApp
````

2. **Configure your API key:**

   Open `Program.cs` and replace the placeholder `"YOUR_API_KEY"` with your actual OpenWeatherMap API key.

3. **Run the app:**

   ```bash
   dotnet run
   ```

4. **Enter a city name when prompted to get the current weather.**

---

## Example Output

```
Enter city name:
london

Weather: Clouds
Temperature: 19.34°C
Feels like: 19.37°C
```

---

## Notes

* Make sure you have an active internet connection for the API call to work.
* The app currently supports fetching weather by city name only.

---

## Improvements & Contributions

Feel free to open issues or submit pull requests for new features like:

* Extended forecast data
* Error handling for invalid input or network errors
* Support for multiple units (Fahrenheit, Kelvin)
* Integration with other weather APIs
* UI enhancements

