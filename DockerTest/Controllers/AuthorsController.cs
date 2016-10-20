
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DockerTest.Data.Model;
using System.Linq;

namespace DockerTest.Controllers
{
    [Route("api/[controller]")]
    public class AuthorsController : Controller
    {
        private readonly ArticleDbContext _context;
        public AuthorsController(ArticleDbContext context)
        {
            _context = context;
        }

        // GET: api/authors
        public IEnumerable<Author> Get()
        {
            return _context.Authors.ToList();
        }

        // GET api/authors/5
        [HttpGet("{id}")]
        public Author Get(int id)
        {
            return _context.Authors.FirstOrDefault(x => x.Id == id);
        }

        // POST api/authors
        [HttpPost]
        public IActionResult Post([FromBody]Author value)
        {
            _context.Authors.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }
}
