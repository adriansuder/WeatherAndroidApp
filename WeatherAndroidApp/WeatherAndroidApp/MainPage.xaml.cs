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
        
        async void OnButtonWeatherClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cityEntry.Text))
            {
                var city = cityEntry.Text;
                WeatherResult weatherResult = await httpClient.GetWeatherProperties(API_LINK + city + "&units=metric&APPID=" + API_KEY);
                BindingContext = weatherResult;
                WeatherIcon.Source = "http://openweathermap.org/img/wn/" + weatherResult._weather[0]._icon + "@2x.png";
                if (gridWeather.IsVisible == false) { gridWeather.IsVisible = true; }
                if (gridForecast.IsVisible == true) { gridForecast.IsVisible = false; }
            }
        }
       
        async void OnButtonForecastClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cityEntry.Text))
            {
                var city = cityEntry.Text;
                ForecastResult forecastResult = await httpClient.GetForecastProperties(API_FORECAST + city + "&units=metric&APPID=" + API_KEY);
                BindingContext = forecastResult;
                WeatherIcon1.Source = "http://openweathermap.org/img/wn/" + forecastResult.list[0].weatherList[0].icon + "@2x.png";
                WeatherIcon2.Source = "http://openweathermap.org/img/wn/" + forecastResult.list[1].weatherList[0].icon + "@2x.png";
                WeatherIcon3.Source = "http://openweathermap.org/img/wn/" + forecastResult.list[2].weatherList[0].icon + "@2x.png";
                WeatherIcon4.Source = "http://openweathermap.org/img/wn/" + forecastResult.list[3].weatherList[0].icon + "@2x.png";
                WeatherIcon5.Source = "http://openweathermap.org/img/wn/" + forecastResult.list[4].weatherList[0].icon + "@2x.png";
                WeatherIcon6.Source = "http://openweathermap.org/img/wn/" + forecastResult.list[5].weatherList[0].icon + "@2x.png";
                WeatherIcon7.Source = "http://openweathermap.org/img/wn/" + forecastResult.list[6].weatherList[0].icon + "@2x.png";
                WeatherIcon8.Source = "http://openweathermap.org/img/wn/" + forecastResult.list[7].weatherList[0].icon + "@2x.png";
                WeatherIcon9.Source = "http://openweathermap.org/img/wn/" + forecastResult.list[8].weatherList[0].icon + "@2x.png";
                WeatherIcon10.Source = "http://openweathermap.org/img/wn/" + forecastResult.list[9].weatherList[0].icon + "@2x.png";
                WeatherIcon11.Source = "http://openweathermap.org/img/wn/" + forecastResult.list[10].weatherList[0].icon + "@2x.png";
                WeatherIcon12.Source = "http://openweathermap.org/img/wn/" + forecastResult.list[11].weatherList[0].icon + "@2x.png";
                WeatherIcon13.Source = "http://openweathermap.org/img/wn/" + forecastResult.list[12].weatherList[0].icon + "@2x.png";
                WeatherIcon14.Source = "http://openweathermap.org/img/wn/" + forecastResult.list[13].weatherList[0].icon + "@2x.png";
                if (gridWeather.IsVisible == true) { gridWeather.IsVisible = false; }
                if (gridForecast.IsVisible == false) { gridForecast.IsVisible = true; }
            }
        }
    }
}
