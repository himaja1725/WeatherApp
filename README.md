# WeatherApp (.NET Console)

A simple and minimalistic .NET 6 console application that fetches real-time weather data using the [OpenWeatherMap API](https://openweathermap.org/api).

---

## Features

- Real-time weather retrieval by city name  
- Displays temperature (°C), weather condition, and "feels like" temperature  
- Uses `HttpClient` for HTTP requests and `System.Text.Json` for JSON parsing  
- Lightweight and easy to understand, ideal for beginners learning API integration in .NET  

---

## Prerequisites

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download) installed on your machine  
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later, with the **“.NET desktop development”** workload installed  
- A free API key from [OpenWeatherMap](https://openweathermap.org/api) (register for a free account)  

---

## Getting Started

Follow these steps to set up and run the application:

1. **Clone the repository:**

   git clone https://github.com/yourusername/WeatherApp.git
   cd WeatherApp
2. **Open the project in Visual Studio:**

-Launch Visual Studio

-Click File > Open > Project/Solution
-Navigate to the cloned folder and open the .csproj file or the folder directly

**Configure your API key:**

-Open Program.cs
-Replace the placeholder "YOUR_API_KEY" with your actual OpenWeatherMap API key

**Restore dependencies and build the project:**

-Visual Studio should automatically restore NuGet packages
-If not, go to Tools > NuGet Package Manager > Manage NuGet Packages for Solution and restore missing packages

**Run the app:**

-Press F5 or click the Start button to run the console application
-When prompted, enter a city name to get current weather information
