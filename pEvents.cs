using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace github_api
{
    internal class pEvents
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("actor")]
        public Actor? Actor { get; set; }

        [JsonPropertyName("repo")]
        public Repo? Repo { get; set; }

        [JsonPropertyName("payload")]
        public Payload? Payload { get; set; }

        [JsonPropertyName("public")]
        public bool IsPublic { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("org")]
        public Org? Org { get; set; }
    }
}
