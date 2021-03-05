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

        public static List<Country> GetCountriesByContinentId(string continentCode)
        {
            string urlParameters = "/country?lang=tr&fields=value%2C%20iso_a2&continent_code=" + continentCode;

            var countries = APICall.GetAsync<List<Country>>(url, apiKey, apiHost, urlParameters).GetAwaiter().GetResult();

            return countries;

        }

        public static List<City> GetCitiesByCountryId(string countryCode)
        {
            string urlParameters = "";

            if (countryCode.Equals("tr"))
                urlParameters = "/state?lang=tr&iso_a2=" + countryCode;
            else
                urlParameters = "/city?lang=tr&iso_a2=" + countryCode;

            var cities = APICall.GetAsync<List<City>>(url, apiKey, apiHost, urlParameters).GetAwaiter().GetResult();

            if (cities == null)
            {
                urlParameters = "/city?lang=tr&iso_a2=" + countryCode;
                cities = APICall.GetAsync<List<City>>(url, apiKey, apiHost, urlParameters).GetAwaiter().GetResult();
            }

            return cities;

        }

    }
}
