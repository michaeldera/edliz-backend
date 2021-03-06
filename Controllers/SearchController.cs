using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Edliz.Models;

namespace Edliz.Controllers
{
        [Route("api/search")]
        [ApiController]
        public class SearchController : ControllerBase
        {
            private readonly EdlizContext _context;

            public SearchController(EdlizContext context)
            {
                _context = context;
            }
            [HttpGet]
            public ActionResult<ICollection<Article>> Get(string searchQuery){
                throw new NotImplementedException(searchQuery);
            } 
        }
}