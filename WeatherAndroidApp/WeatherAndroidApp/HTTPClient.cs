using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Diagnostics;


namespace WeatherAndroidApp
{
    public class HTTPClient
    {
        HttpClient httpClient;
        public HTTPClient()
        {
            httpClient = new HttpClient();
        }
        public async Task<WeatherResult> GetWeatherProperties(string cityWeather)
        {
            WeatherResult weatherResult = null;
            var temp = await httpClient.GetAsync(cityWeather);
            if (temp.IsSuccessStatusCode)
            {
                var responseData = await temp.Content.ReadAsStringAsync();
                weatherResult = JsonConvert.DeserializeObject<WeatherResult>(responseData);
            }
            return weatherResult;
        }
        public async Task<ForecastResult> GetForecastProperties(string cityWeather)
        {
            ForecastResult forecastResult = null;
            var temp = await httpClient.GetAsync(cityWeather);
            if (temp.IsSuccessStatusCode)
            {
                var responseData = await temp.Content.ReadAsStringAsync();
                forecastResult = JsonConvert.DeserializeObject<ForecastResult>(responseData);
            }
            return forecastResult;
        }

    }
}
