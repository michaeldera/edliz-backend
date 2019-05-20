using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Edliz.Models;

namespace Edliz.Controllers
{
    [Route("/[controller]")]
    [ApiController]

    class ArticlesController : ControllerBase
    {
        //Gets All chapters
        [HttpGet]
        public ActionResult<ICollection<Article>> Get(){
            return new Article[]{ new Article(), new Article()}; 
        }
        
        [HttpGet("{id}")]
        public ActionResult<Article> Get(int id)
        {
            return new Article();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Article value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Article value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    
}