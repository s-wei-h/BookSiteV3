using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSite.Models
{
    public class BookShelfDBContext :DbContext
    {
        public BookShelfDBContext (DbContextOptions<BookShelfDBContext> options) : base (options)
        {

        }

        public DbSet<Book> Projects { get; set; }

        internal object GetPendingMigrations()
        {
            throw new NotImplementedException();
        }
    }
}
