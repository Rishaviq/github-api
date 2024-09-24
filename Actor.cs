using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace github_api
{
    internal class Actor
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("login")]
        public string logIn{ get; set; }

        [JsonPropertyName("display_login")]
        public string display_login { get; set; }

        [JsonPropertyName("gravatar_id")]
        public string gravatar_id { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("avatar_url")]
        public string avatar_url { get; set; }

    }
}
