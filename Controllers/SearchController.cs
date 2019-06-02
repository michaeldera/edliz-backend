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
    private readonly IElasticClient _elasticClient;

    public SearchController(IElasticClient elasticClient)
    {
      _elasticClient = elasticClient;
    }
    [HttpGet]
    public Task<ActionResult<IEnumerable<Article>>> Get(string q)
    {
       var results = _elasticClient.Search<Article>(a => a
       .Query(_q => _q
        .Match(m => m
          .Field(f => f.ArticleBody)
          .Query(q)
          )
      ));
      return (IEnumerable<Article>)results.Documents;
    }
  }
}