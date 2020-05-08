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
        static string locationUrl = "http://dataservice.accuweather.com/locations/v1/cities/search?apikey=pJF9LbDmPs9nMLRW0s09t1OxQTGgowa1&q=blairs";
        static string fiveDayForecastUrl = "http://dataservice.accuweather.com/forecasts/v1/daily/5day/2219475?apikey=pJF9LbDmPs9nMLRW0s09t1OxQTGgowa1&q";
        static string currentConditionsUrl = "http://dataservice.accuweather.com/currentconditions/v1/2219475?apikey=pJF9LbDmPs9nMLRW0s09t1OxQTGgowa1&q";
        static string twelveHourForecastUrl = "http://dataservice.accuweather.com/forecasts/v1/hourly/12hour/2219475?apikey=pJF9LbDmPs9nMLRW0s09t1OxQTGgowa1&q";


        public JArray parseLocation() {
            WebClient client = new WebClient();
            string locationData = client.DownloadString(locationUrl);

            JArray location = JArray.Parse(locationData);
            return location;
        }        

        public JArray parseFiveDay()
        {
            WebClient client = new WebClient();
            string fiveDayData = client.DownloadString(fiveDayForecastUrl);

            JArray fiveDay = JArray.Parse(fiveDayData);
            return fiveDay;
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
    }
}