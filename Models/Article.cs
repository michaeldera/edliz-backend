using System;
using System.Collections.Generic;
using System.Linq;

namespace Edliz.Models
{
    class Article
    {
        public string ArticleBody { get; set; }
        public string ArticleSection { get; set; }
        public string BackStory {get; set; }
        public int WordCount { get; set; }
        public string AlternativeHeadline { get; set; }
        public string Headline {get; set;} 
        public string[] KeyWords {get; set;}
    }
    
}