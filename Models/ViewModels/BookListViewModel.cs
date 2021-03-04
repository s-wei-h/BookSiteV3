using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//use this class to gather Inumberable and paging info to later be used in index
namespace BookSite.Models.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> BookShelf { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory {get;set;}

    }
}
