using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WeatherAndroidApp
{   
    public class WeatherResult
    {
        [JsonProperty("name")]
        public string _name { get; set; }

        [JsonProperty("coord")]
        public Coord _coord { get; set; }

        [JsonProperty("weather")]
        public List<Weather> _weather { get; set; }

        [JsonProperty("base")]
        public string _base { get; set; }

        [JsonProperty("main")]
        public Main _main { get; set; }

        [JsonProperty("clouds")]
        public Clouds _clouds { get; set; }

        [JsonProperty("wind")]
        public Wind _wind { get; set; }

        [JsonProperty("sys")]
        public Sys _sys { get; set; }

        [JsonProperty("dt")]
        public long _dt { get; set; }

        [JsonProperty("cod")]
        public long _cod { get; set; }

        [JsonProperty("id")]
        public long _id { get; set; }

        [JsonProperty("visibility")]
        public long _visibility { get; set; }
    }
    public class Wind
    {
        [JsonProperty("speed")]
        public double _speed { get; set; }

        [JsonProperty("deg")]
        public long _deg { get; set; }
    }
    public class Coord
    {
        [JsonProperty("lat")]
        public double _lat { get; set; }
        [JsonProperty("lon")]
        public double _lon { get; set; }
    }
    public class Main
    {
        [JsonProperty("temp")]
        public double _temperature { get; set; }

        [JsonProperty("pressure")]
        public long _pressure { get; set; }

        [JsonProperty("humidity")]
        public long _humidity { get; set; }

        [JsonProperty("temp_min")]
        public double _tempMin { get; set; }

        [JsonProperty("temp_max")]
        public double _tempMax { get; set; }
    }
    public class Clouds
    {
        [JsonProperty("all")]
        public long _all { get; set; }
    }
    public class Sys
    {
        [JsonProperty("type")]
        public long _type { get; set; }

        [JsonProperty("id")]
        public long _id { get; set; }

        [JsonProperty("message")]
        public double _message { get; set; }

        [JsonProperty("country")]
        public string _country { get; set; }

        [JsonProperty("sunrise")]
        public long _sunrise { get; set; }

        [JsonProperty("sunset")]
        public long _sunset { get; set; }
    }
    public class Weather
    {
        [JsonProperty("id")]
        public long _id { get; set; }

        [JsonProperty("main")]
        public string _main { get; set; }

        [JsonProperty("description")]
        public string _description { get; set; }

        [JsonProperty("icon")]
        public string _icon { get; set; }
    }

}
