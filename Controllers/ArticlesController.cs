using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
        public ActionResult<ICollection<Article>> Get()
        {
            return new Article[] { new Article(), new Article() };
        }

        // GET api/articles/{id}: Get a specific chapter by Id 
        [HttpGet("{id}")]
        public ActionResult<Article> Get(int id)
        {
            return new Article();
        }

        // POST api/articles : create a new Article
        [HttpPost]
        public void Post([FromBody] Article value)
        {
        }

        // PUT api/articles/{id}: Edit an article
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Article value)
        {
        }

        // DELETE api/articles/{id} : delete an article
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

}