using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Edliz.Models;

namespace Edliz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ArticlesController : ControllerBase
    {

        private readonly EdlizContext _context;

        public ArticlesController(EdlizContext context)
        {
            _context = context;
        }
        
        //GET api/articles/: Get all chapters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Article>>> Get()
        {
            return await _context.Articles.ToListAsync();
        }

        // GET api/articles/{id}: Get a specific chapter by Id 
        [HttpGet("{id}")]
        public async Task<ActionResult<Article>> Get(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            if(article == null)
            {
              return NotFound();
            }
            return article;

        }

        // POST api/articles : create a new Article
        [HttpPost]
        public void Post([FromBody] Article value)
        {
          throw new NotImplementedException("Operation not available in this version");
        }

        // PUT api/articles/{id}: Edit an article
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Article value)
        {
          throw new NotImplementedException("Operation not available in this version");
        }

        // DELETE api/articles/{id} : delete an article
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
          throw new NotImplementedException("Operation not available in this version");
        }
    }

}