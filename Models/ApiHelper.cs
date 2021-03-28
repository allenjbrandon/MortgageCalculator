using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace MortgageCalculator.Models
{
    public class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Add("X-Master-Key", "$2b$10$Z7uCDHW.uOurfCQ7.DCweucnPqt.YNH8V6dKE5GIPZvHLZvKDk.RK");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}

//request.AddHeader("X-Master-Key", "$2b$10$Z7uCDHW.uOurfCQ7.DCweucnPqt.YNH8V6dKE5GIPZvHLZvKDk.RK");
