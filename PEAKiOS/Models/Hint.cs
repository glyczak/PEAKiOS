using System;
using Newtonsoft.Json;
namespace PEAKiOS.Models
{
    public class Hint
    {
        [JsonProperty("moduleId")]
        public int ModuleId { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
