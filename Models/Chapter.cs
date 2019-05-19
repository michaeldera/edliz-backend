using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Edliz.Models
{
    class Chapter
    {
        public string Title { get; set; }
        public int Number { get; set; }
        public string Content { get; set; }
           
    }
    
}