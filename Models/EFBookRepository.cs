using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSite.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookShelfDBContext _context;

        //constructor
        public EFBookRepository(BookShelfDBContext context)
        {
            _context = context;
        }
        public IQueryable<Book> BookShelf => _context.Projects;
    }
}
