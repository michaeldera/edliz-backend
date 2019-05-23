using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Edliz.Models;

namespace Edliz
{
    public class EdlizContext : DbContext
    {
        public DbSet<Article> Articles {get; set;}
    }

}