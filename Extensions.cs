using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DTOs;
using WebApplication1.Entities;

namespace WebApplication1
{
    public static class Extensions
    {
        public static ArticleDTO AsDTO(this Article article)
        {
            return new ArticleDTO()
            {
                Id = article.Id,
                Name = article.Name,
            };
        }
    }
}
