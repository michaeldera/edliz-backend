using System;
using System.Collections.Generic;
using System.Linq;
using Nest;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Edliz.Models;

namespace Edliz.Controllers
{
  [Route("api/search")]
  [ApiController]
  public class SearchController : ControllerBase
  {
    private readonly EdlizContext _context;
    private readonly ElasticClient _client;

    public SearchController(EdlizContext context)
    {
    }
    [HttpGet]
    public ActionResult<ICollection<Article>> Get(string q)
    {
      var searchResponse = _client.Search<Article>(a => a
       .Query(_q => _q
        .Match(m => m
          .Field(f => f.ArticleBody)
          .Query(q)
          )
     ));

      var results = searchResponse.Documents.ToList();
      return results;
    }
  }
}