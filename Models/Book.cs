using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookSite.Models
{
    public class Book
    {
        //key marks property as primary key
        [Key]
        public int BookID { get; set; }
        public string Title { get; set; }
        public string AuthorFirst { get; set; }
        public string AuthorLast { get; set; }
        public string Publisher { get; set; }
        //regular expression regulates the format
        [RegularExpression(@"([1-91-91-9-1-91-91-91-91-91-91-91-91-91-9])")]
        public string ISBN { get; set; }
        public string Category { get; set; }
        public Double Price { get; set; }
        public int NumPages { get; set; }

    }
}
