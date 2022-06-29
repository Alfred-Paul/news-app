using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace ConsoleApp1
{
    class Program
    {
        private static HttpClient client = new HttpClient();

        private static readonly string APIKey = "9c179b2e-8f8c-487c-ad16-8f894e1574f0";

        private static string url = @"https://content.guardianapis.com/search?q=debate%20AND%20economy&tag=politics/politics&from-date=2014-01-01&api-key=9c179b2e-8f8c-487c-ad16-8f894e1574f0&format=json";

        private static readonly IArticleRepository repository = new ArticleRepository();
        
        static void Main()
        {
            //Perform asynchronous httprequest and add it to repository
             repository.AddArticle(GetArticleAsync(url).GetAwaiter().GetResult());
        }

        //HTTP request returns article obj formatted from json data
        static async Task<Article> GetArticleAsync(string path)
        {
            client.BaseAddress = new Uri(path);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Article article = null;
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string jsonString = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(jsonString);
                article = JsonSerializer.Deserialize<Article>(jsonString);
                Console.WriteLine();
                Console.WriteLine(article.Status);
            }
            else
            {
                Console.Write(response.Content);
            }
            return article;
        }
    }
}
