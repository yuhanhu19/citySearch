using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace citySearch
{
    public class CitySearch
    {
        readonly IList<string> _cityNames = new List<string>
        {
            "Paris", "Budapest", "Skopje", "Rotterdam", "Valencia", "Vancouver", "Amsterdam", "Vienna", "Sydney",
            "New York City", "London", "Bangkok", "Hong Kong", "Dubai", "Rome", "Istanbul"
        };

        public string[] Search(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new Exception("Search text must be provided");
            }

            if (text.Length >= 2)
            {
                return SearchCity(text);
            }

            return new string[] { };
        }

        private string[] SearchCity(string text)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return _cityNames.Where(cityName => cityName.StartsWith(textInfo.ToTitleCase(text))).ToArray();
        }
    }
}