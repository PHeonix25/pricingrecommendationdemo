using System;
using System.Linq;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Requesting Unactioned Pricing Recommendations!");

            var client = new HttpClient { BaseAddress = new Uri(ConstantSettings.RequestUrl) };
            var response = client.GetAsync("").Result;
            var responseBody = response.Content.ReadAsStringAsync().Result;
            var results = JsonConvert.DeserializeObject<List<PricingRecommendation>>(responseBody);
            Console.WriteLine($"There are currently {results.Count} unactioned pricing recommendations " +
                              $"for {results.Select(p => p.ProductId).Distinct().Count()} distinct products");
        }
    }
}
