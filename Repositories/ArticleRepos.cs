using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.Repositories
{

    public class ArticleRepos : IArticleRepository
    {
        private readonly List<Article> articles = new()
        {
            new Article { Id = 1, Name = "Test" },
            new Article { Id = 2, Name = "OtroTest" }
        };

        public IEnumerable<Article> GetArticles()
        {
            return articles;
        }

        public Article GetArticle(int id)
        {
            return articles.Where(x => x.Id == id).FirstOrDefault();
        }

        public void CreateArticle(Article article)
        {
            //throw new NotImplementedException();
        }
    }
}
