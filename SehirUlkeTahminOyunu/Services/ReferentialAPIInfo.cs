using SehirUlkeTahminOyunu.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SehirUlkeTahminOyunu.Services
{
    public class ReferentialAPIInfo
    {
        const string url = "https://referential.p.rapidapi.com/v1";
        const string apiKey = "<your-API-key>";
        const string apiHost = "referential.p.rapidapi.com";

        public static List<Continent> GetContinents()
        {
            string urlParameters = "/continent?lang=tr&fields=value%2C%20iso_a2";
            var continents = APICall.GetAsync<List<Continent>>(url, apiKey, apiHost, urlParameters).GetAwaiter().GetResult();

            if (continents != null)
            {
                for (int i = 0; i < continents.Count; i++)
                {
                    continents[i].Id = i + 1;
                }
            }

            return continents;

        }
    }
}
