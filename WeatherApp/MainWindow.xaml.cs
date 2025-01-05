using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string PlaceholderText = "Enter city name...";

        public class WeatherData
        {
            public Main Main { get; set; }
            public string Name { get; set; }
        }

        public class Main
        {
            public double Temp { get; set; }
            public double Humidity { get; set; }
        }

        private async Task GetWeatherAsync(string cityName)
        {
            //Username: none_meyer_lisa
            //Password: 4rkET1B97s
           // Valid until: 2025-01-18

            const string apiKey = "712ddd0ee96c4bca12f84d2284dbb1ac"; // Replace with your OpenWeatherMap API key
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=metric";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string response = await client.GetStringAsync(url);
                    var weatherData = JsonConvert.DeserializeObject<WeatherData>(response);

                    WeatherOutput.Text = $"City: {weatherData.Name}\n" +
                                         $"Temperature: {weatherData.Main.Temp}°C\n" +
                                         $"Humidity: {weatherData.Main.Humidity}%";
                }
                catch
                {
                    WeatherOutput.Text = "Error fetching weather data. Please check the city name.";
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            CityInput.Text = PlaceholderText;
            CityInput.Foreground = Brushes.Gray; // Set initial placeholder color
        }

        private void CityInput_GotFocus(object sender, RoutedEventArgs e)
        {
            if (CityInput.Text == PlaceholderText)
            {
                CityInput.Text = string.Empty;
                CityInput.Foreground = Brushes.Black; // Change text color to black
            }
        }

        private void CityInput_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CityInput.Text))
            {
                CityInput.Text = PlaceholderText;
                CityInput.Foreground = Brushes.Gray; // Change text color to gray
            }
        }

        private async void GetWeatherButton_Click(object sender, RoutedEventArgs e)
        {
            string cityName = CityInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(cityName))
            {
                WeatherOutput.Text = "Please enter a city name.";
            }
            else
            {
                WeatherOutput.Text = "Fetching weather data...";
                await GetWeatherAsync(cityName);
            }
        }

    }
}