using System;
using System.Collections.Generic;

namespace citySearch
{
    public class CitySearch
    {
        IList<string> cityNames = new List<string>
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

            return null;
        }
    }
}