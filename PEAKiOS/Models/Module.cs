using System;
using Newtonsoft.Json;
namespace PEAKiOS.Models
{
    public class Module
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
