using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSite.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> BookShelf { get; }

    }
}
