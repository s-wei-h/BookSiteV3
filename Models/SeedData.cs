using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSite.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookShelfDBContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookShelfDBContext>();

            //check for migrations
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            //If there is nothing in the database, at this data
            if (!context.Projects.Any())
            {
                context.Projects.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Category = "Fiction, Classic",
                        Price = 9.95,
                        NumPages = 1488
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris Kearns",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Category = "Non-fiction, Biography",
                        Price = 14.58,
                        NumPages = 944
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Category = "Non-fiction, Biography",
                        Price = 21.54,
                        NumPages = 832
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald C.",
                        AuthorLast = "White",
                        Publisher = "Random house",
                        ISBN = "978-0812981254",
                        Category = "Non-fiction, Biography",
                        Price = 11.61,
                        NumPages = 864
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Category = "Non-fiction, Historical",
                        Price = 13.33,
                        NumPages = 528
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Category = "Fiction, Historical Fiction",
                        Price = 15.95,
                        NumPages = 228
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Category = "Non-fiction, Self-Help",
                        Price = 14.99,
                        NumPages = 304
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Category = "Non-fiction, Self-Help",
                        Price = 21.66,
                        NumPages = 240
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Category = "Non-fiction, Business",
                        Price = 29.16,
                        NumPages = 400
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Category = "Fiction, Thrillers",
                        Price = 15.03,
                        NumPages = 642
                    },

                    new Book
                    {
                        Title = "Graceling",
                        AuthorFirst = "Kristin",
                        AuthorLast = "Cashore",
                        Publisher = "Harcourt",
                        ISBN = "978-0152063962",
                        Category = "Fiction, Fantasy",
                        Price = 9.99,
                        NumPages = 471
                    },

                    new Book
                    {
                        Title = "Shoe Dog",
                        AuthorFirst = "Phil",
                        AuthorLast = "Knight",
                        Publisher = "Scribner",
                        ISBN = "978-1508211808",
                        Category = "Non-fiction, Biography",
                        Price = 14.99,
                        NumPages = 386
                    },

                    new Book

                    {
                        Title = "Outliers",
                        AuthorFirst = "Malcolm",
                        AuthorLast = "Gladwell",
                        Publisher = "Back Bay Books",
                        ISBN = "978-0316017930",
                        Category = "Non-fiction, Self-Help",
                        NumPages = 304
                    }
                );

                //save all changes
                context.SaveChanges();
            }
        }
    }
}
