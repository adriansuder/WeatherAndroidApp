using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeatherAndroidApp
{
    public partial class MainPage : ContentPage
    {
        public static string API_KEY = "26553c7563ad071303a5d9f9ed77222b";
        public static string API_LINK = "http://api.openweathermap.org/data/2.5/weather?q=";
        public static string API_FORECAST = "http://api.openweathermap.org/data/2.5/forecast?q=";

        HTTPClient httpClient;
        public MainPage()
        {
            InitializeComponent();
            httpClient = new HTTPClient();
        }
        WeatherResult weatherResult;
        async void OnButtonWeatherClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cityEntry.Text))
            {
                var city = cityEntry.Text;
                weatherResult = await httpClient.GetWeatherProperties(API_LINK + city + "&units=metric&APPID=" + API_KEY);
                BindingContext = weatherResult;
                WeatherIcon.Source = "http://openweathermap.org/img/wn/" + weatherResult._weather[0]._icon + "@2x.png";
                if (gridWeather.IsVisible == false) { gridWeather.IsVisible = true; }
                if (gridForecast.IsVisible == true) { gridForecast.IsVisible = false; }
            }
        }
        ForecastResult forecastResult;
        async void OnButtonForecastClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cityEntry.Text))
            {
                var city = cityEntry.Text;
                forecastResult = await httpClient.GetForecastProperties(API_FORECAST + city + "&units=metric&APPID=" + API_KEY);
                BindingContext = forecastResult;
                if (gridWeather.IsVisible == true) { gridWeather.IsVisible = false; }
                if (gridForecast.IsVisible == false) { gridForecast.IsVisible = true; }
            }
        }
    }
}
