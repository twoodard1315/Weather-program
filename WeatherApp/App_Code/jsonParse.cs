using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net;

namespace WeatherApp.App_Code
{
    public class jsonParse
    {
        static string apiKey = "pJF9LbDmPs9nMLRW0s09t1OxQTGgowa1";
        static string city = "Blairs";
        
        static string fiveDayForecastUrl = "http://dataservice.accuweather.com/forecasts/v1/daily/5day/2219475?apikey=pJF9LbDmPs9nMLRW0s09t1OxQTGgowa1&q";
        static string currentConditionsUrl = "http://dataservice.accuweather.com/currentconditions/v1/2219475?apikey=pJF9LbDmPs9nMLRW0s09t1OxQTGgowa1&q";
        static string twelveHourForecastUrl = "http://dataservice.accuweather.com/forecasts/v1/hourly/12hour/2219475?apikey=pJF9LbDmPs9nMLRW0s09t1OxQTGgowa1&q";
        static string dailyForecastUrl = "http://dataservice.accuweather.com/forecasts/v1/daily/1day/2219475?apikey=pJF9LbDmPs9nMLRW0s09t1OxQTGgowa1&q";


        public JArray parseLocation(String locationName) {

            WebClient client = new WebClient();
            string locationUrl = "http://dataservice.accuweather.com/locations/v1/cities/search?apikey=pJF9LbDmPs9nMLRW0s09t1OxQTGgowa1&q=" + locationName;
            string locationData = client.DownloadString(locationUrl);

            JArray location = JArray.Parse(locationData);
            //string temp = location[1]["PrimaryPostalCode"].ToString();

            return location;
        }        

        public string parseFiveDay()
        {
            WebClient client = new WebClient();
            string fiveDayData = client.DownloadString(fiveDayForecastUrl);

            JObject fiveDay = JObject.Parse(fiveDayData);
            string temp = fiveDay["DailyForecasts"][0].ToString();
            return temp;
        }

        public string parseCurrent()
        {
            string temp = String.Empty;
            WebClient client = new WebClient();
            string currentData = client.DownloadString(currentConditionsUrl);

            JArray current = JArray.Parse(currentData);
            temp = current[0]["Temperature"]["Imperial"]["Value"].ToString();
            return temp;
            //return current["Weather Text"];
        }

        public JArray parseTwelve()
        {
            WebClient client = new WebClient();
            string twelveData = client.DownloadString(twelveHourForecastUrl);

            JArray twelveHour = JArray.Parse(twelveData);
            return twelveHour;
        }

        public JObject parseDaily()
        {
            WebClient client = new WebClient();
            string dailyData = client.DownloadString(dailyForecastUrl);

            JObject dailyForecast = JObject.Parse(dailyData);
            return dailyForecast;
        }
    }
}