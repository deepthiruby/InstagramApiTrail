using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InstagramApiTrail.ViewModels
{
    public class InstagramMediaContentResult
    {
        [JsonProperty("data")]
        public IEnumerable<InstagramMediaContent> Data { get; set; }
    }
}