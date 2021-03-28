using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace MortgageCalculator.Models
{
    public class RateProcessor
    {
        public static async Task<double> LoadRate()
        {
            string url = "https://api.jsonbin.io/v3/b/605fd98eb0a45d7e602709a4/2/";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if(response.IsSuccessStatusCode)
                {
                    Rate rates = await response.Content.ReadAsAsync<Rate>();

                    double interestRate = rates.Record.Rates * .01;
                    return interestRate;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}