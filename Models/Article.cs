using System;
using System.Collections.Generic;
using System.Linq;

namespace Edliz.Models
{
    public class Article
    {
        public int Id {get; set; }
        public string ArticleBody { get; set; }
        public string ArticleSection { get; set; }
        public string AlternativeHeadline { get; set; }
        public string Headline {get; set;} 
        public string[] KeyWords {get; set;}
    }
    
}