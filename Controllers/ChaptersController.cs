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

    class ChaptersController : ControllerBase
    {
        //Gets All chapters
        [HttpGet]
        public ActionResult<ICollection<Chapter>> Get(){
            return new Chapter[]{ new Chapter(), new Chapter()}; 
        }
        
    }
    
}