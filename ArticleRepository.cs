using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class ArticleRepository : IArticleRepository
    {
        private List<Article> Articles { get; set; }
        
        public ArticleRepository()
        {
            Articles = new List<Article>();
        }

        public Article GetArticle()
        {
            return Articles.FirstOrDefault();
        }

        IEnumerable<Article> IArticleRepository.GetArticles()
        {
            return Articles;
        }

        public void AddArticle(Article article)
        {
            Articles.Add(article);
        }

        public void SetArticleList(List<Article> articles)
        {
            Articles = articles;
        }
    }
}
