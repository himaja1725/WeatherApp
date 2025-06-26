A simple and minimalistic .NET 6 console application that fetches real-time weather data using the OpenWeatherMap API.

Features
Real-time weather retrieval by city name

Displays temperature (°C), weather condition, and "feels like" temperature

Uses HttpClient for HTTP requests and System.Text.Json for JSON parsing

Lightweight and easy to understand, ideal for beginners learning API integration in .NET

Prerequisites
Install .NET 6.0 SDK on your machine

Install Visual Studio 2022 or later with the “.NET desktop development” workload

A free API key from OpenWeatherMap (register for a free account)

Getting Started
Follow these steps to set up and run the application:

Clone the repository:

bash
Copy
Edit
git clone https://github.com/yourusername/WeatherApp.git
cd WeatherApp
Open the project in Visual Studio:

Launch Visual Studio

Click File > Open > Project/Solution

Navigate to the cloned folder and open the .csproj or solution file if available, or open the folder directly

Configure your API key:

Open the Program.cs file and replace the placeholder "YOUR_API_KEY" with your actual OpenWeatherMap API key.

Restore dependencies and build the project:

Visual Studio should automatically restore any required packages. If not, use Tools > NuGet Package Manager > Manage NuGet Packages to install missing dependencies.

Run the app:

Press F5 or click the Start button in Visual Studio to run the console application.

Enter a city name when prompted to receive current weather information.

Example Output
Enter city name:
london

Weather: Clouds
Temperature: 19.34°C
Feels like: 19.37°C

Notes
Ensure you have an active internet connection for API requests.

The app currently supports weather data retrieval by city name only.

Potential Improvements
Contributions and suggestions are welcome. Possible enhancements include:

Support for extended weather forecasts

Robust error handling for invalid inputs or network issues

Option to switch between different temperature units (Fahrenheit, Kelvin)

Integration with additional weather APIs

Improved user interface and user experience

Thank you for checking out WeatherApp!
