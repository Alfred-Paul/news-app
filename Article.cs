using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    public class Article
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        //public int total { get; set; }

        //public int pageSize { get; set; }

        //public int currentPage { get; set; }

        //public int pages { get; set; }

        //public string orderBy { get; set; }
        //public int id { get; set; }

        //public int sectionId { get; set; }

        //public int sectionName { get; set; }

        //public string webTitle { get; set; }
        //public string webUrl { get; set; }
        //public string apiUrl {get; set;}
    }
}
