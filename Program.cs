using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace WeatherApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter city name:");
            string city = Console.ReadLine()!;

            string apiKey = "d438018717a1666bc85f6241cdf28417"; // Your OpenWeatherMap API Key
            string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    JsonDocument doc = JsonDocument.Parse(responseBody);
                    JsonElement root = doc.RootElement;

                    string weather = root.GetProperty("weather")[0].GetProperty("main").GetString()!;
                    double temp = root.GetProperty("main").GetProperty("temp").GetDouble();
                    double feelsLike = root.GetProperty("main").GetProperty("feels_like").GetDouble();

                    Console.WriteLine($"\nWeather: {weather}");
                    Console.WriteLine($"Temperature: {temp}°C");
                    Console.WriteLine($"Feels like: {feelsLike}°C");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            // ⬇️ Keeps the window open to see the result
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
