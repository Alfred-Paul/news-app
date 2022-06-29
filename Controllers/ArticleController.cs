using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Repositories;
using WebApplication1.Entities;
using WebApplication1.DTOs;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleRepository repository;

        public ArticleController(IArticleRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<ArticleDTO> GetArticles()
        {
            var articles = repository.GetArticles().Select(article => article.AsDTO());
            return articles;
        }

        [HttpGet("{Id}")]
        public ActionResult<ArticleDTO> GetArticle(int Id)
        {
            var article = repository.GetArticle(Id).AsDTO();
            
            if(article is null)
            {
                return NotFound();
            }
            
            return article;
        }

        [HttpPost]
        public ActionResult<ArticleDTO> CreateArticle(CreateArticleDTO articleDTO)
        {
            Article article = new()
            {
                Id = articleDTO.Id,
                Name = articleDTO.Name,
            };

            repository.CreateArticle(article);

            return CreatedAtAction(nameof(GetArticle), new { id = article.Id }, article.AsDTO());
        }
    }
}
