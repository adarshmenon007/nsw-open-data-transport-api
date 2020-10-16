using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace NSWOpenDataTransportLibrary
{
    public class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("https://api.transport.nsw.gov.au/v1/live/cameras");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ApiClient.DefaultRequestHeaders.Add("Authorization", "apikey j1zHbAwDsYNo4sR9FpInRVzIX8698p9JxomI");
        }
    }
}
