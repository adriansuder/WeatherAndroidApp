using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WeatherAndroidApp
{

    public class ForecastResult
    {
        [JsonProperty("cod")]
        public string cod { get; set; }
        [JsonProperty("message")]
        public double message { get; set; }
        [JsonProperty("cnt")]
        public int cnt { get; set; }
        [JsonProperty("list")]
        public List<ListForecast> list { get; set; }
        [JsonProperty("city")]
        public CityForecast city { get; set; }
    }
    public class MainForecast
    {
        [JsonProperty("temp")]
        public double temp { get; set; }
        [JsonProperty("temp_min")]
        public double temp_min { get; set; }
        [JsonProperty("temp_max")]
        public double temp_max { get; set; }
        [JsonProperty("pressure")]
        public double pressure { get; set; }
        [JsonProperty("sea_level")]
        public double sea_level { get; set; }
        [JsonProperty("grnd_level")]
        public double grnd_level { get; set; }
        [JsonProperty("humidity")]
        public int humidity { get; set; }
        [JsonProperty("temp_kf")]
        public double temp_kf { get; set; }
    }

    public class WeatherForecast
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("main")]
        public string main { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
        [JsonProperty("icon")]
        public string icon { get; set; }
    }

    public class CloudsForecast
    {
        [JsonProperty("all")]
        public int all { get; set; }
    }

    public class WindForecast
    {
        [JsonProperty("speed")]
        public double speed { get; set; }
        [JsonProperty("deg")]
        public double deg { get; set; }
    }

    public class RainForecast
    {
        [JsonProperty("3h")]
        public double _3h { get; set; }
    }

    public class SysForecast
    {
        [JsonProperty("pod")]
        public string pod { get; set; }
    }

    public class ListForecast
    {
        [JsonProperty("dt")]
        public int dt { get; set; }
        [JsonProperty("main")]
        public MainForecast main { get; set; }
        [JsonProperty("weather")]
        public List<WeatherForecast> weather { get; set; }
        [JsonProperty("clouds")]
        public CloudsForecast clouds { get; set; }
        [JsonProperty("wind")]
        public WindForecast wind { get; set; }
        [JsonProperty("rain")]
        public RainForecast rain { get; set; }
        [JsonProperty("sys")]
        public SysForecast sys { get; set; }
        [JsonProperty("dt_txt")]
        public string dt_txt { get; set; }
    }

    public class CoordForecast
    {
        [JsonProperty("lat")]
        public double lat { get; set; }
        [JsonProperty("lon")]
        public double lon { get; set; }
    }

    public class CityForecast
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("coord")]
        public Coord coord { get; set; }
    }

}    
