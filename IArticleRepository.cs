using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IArticleRepository
    {
        public Article GetArticle();

        public IEnumerable<Article> GetArticles();

        public void AddArticle(Article article);

        public void SetArticleList(List<Article> articles);
    }
}
