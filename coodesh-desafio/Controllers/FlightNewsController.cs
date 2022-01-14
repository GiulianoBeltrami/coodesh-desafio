using coodesh_desafio.Context;
using coodesh_desafio.Models;
using Microsoft.AspNetCore.Mvc;

namespace coodesh_desafio.Controllers
{
    [ApiController]
    [Route("")]
    public class FlightNewsController : ControllerBase
    {
        private FlightNewsContext _context;

        public FlightNewsController(FlightNewsContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Produces("application/json")]
        public ActionResult<string> Get()
        {
            return Ok("Back-end Challenge 2021 🏅 - Space Flight News");
        }

        [HttpGet]
        [Produces("application/json")]
        [Route("articles/")]
        public ActionResult<string> GetArticles()
        {
            var articles = _context.FlightNews;
            return Ok(articles);
        }

        [HttpGet]
        [Produces("application/json")]
        [Route("articles/{id}")]
        public ActionResult<string> GetArticle(int id)
        {
            var article = _context.FlightNews.Find(id);

            return Ok(article);
        }

        [HttpPost]
        [Produces("application/json")]
        [Route("articles/")]
        public ActionResult<string> PostArticle([FromBody] FlightNews flightNews)
        {
            var newFlightNews = _context.FlightNews.Add(flightNews);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetArticle), new { id = newFlightNews.});
        }

        [HttpPut]
        [Produces("application/json")]
        [Route("articles/{id}")]
        public ActionResult<string> PutArticle(int id)
        {
            return Ok("Back-end Challenge 2021 🏅 - Space Flight News");
        }

        [HttpDelete]
        [Produces("application/json")]
        [Route("articles/{id}")]
        public ActionResult<string> DeleteArticle(int id)
        {
            return Ok("Back-end Challenge 2021 🏅 - Space Flight News");
        }
    }
}
