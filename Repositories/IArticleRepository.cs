using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.Repositories
{
    public interface IArticleRepository
    {
        Article GetArticle(int id);
        IEnumerable<Article> GetArticles();

        void CreateArticle(Article article);
    }
}
