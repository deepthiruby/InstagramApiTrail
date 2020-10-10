using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InstagramApiTrail.ViewModels
{
    public class InstagramLongLiveAccessToken
    {
        [JsonProperty("expires_in")]
        public int Expires_In
        {
            get; set;
        }
    }
}