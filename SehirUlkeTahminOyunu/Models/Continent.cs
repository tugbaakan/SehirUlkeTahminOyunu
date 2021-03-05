using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SehirUlkeTahminOyunu.Models
{
    public class Continent
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
        public int Id { get; set; }
    }
}
