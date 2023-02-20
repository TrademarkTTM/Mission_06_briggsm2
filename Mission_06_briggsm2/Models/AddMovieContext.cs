using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_06_briggsm2.Models
{
    public class AddMovieContext : DbContext
    {
        //Constructor
        public AddMovieContext (DbContextOptions<AddMovieContext> options) : base (options)
        {
            //Leave blank for now
        }

        public DbSet<AddMovieResponce> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Action/Adventure"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Horror/Action"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Comedy"
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Drama"
                },
                new Category
                {
                    CategoryId = 5,
                    CategoryName = "Family"
                },
                new Category
                {
                    CategoryId = 6,
                    CategoryName = "Horror/Suspense"
                },
                new Category
                {
                    CategoryId = 7,
                    CategoryName = "Miscellaneous"
                },
                new Category
                {
                    CategoryId = 8,
                    CategoryName = "Television"
                },
                new Category
                {
                    CategoryId = 9,
                    CategoryName = "VHS"
                }
                );

            mb.Entity<AddMovieResponce>().HasData(

                new AddMovieResponce
                {
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "Uncharted",
                    Year = 2022,
                    Director = "Ruben Fleischer",
                    Rating = "PG-13",
                    Edited = false,
                    Lent_To = null,
                    Notes = null
                },
                new AddMovieResponce
                {
                    MovieId = 2,
                    CategoryId = 1,
                    Title = "Top Gun: Maverick",
                    Year = 2022,
                    Director = "Joseph Kosinski",
                    Rating = "PG-13",
                    Edited = false,
                    Lent_To = null,
                    Notes = null
                },
                new AddMovieResponce
                {
                    MovieId = 3,
                    CategoryId = 2,
                    Title = "World War Z",
                    Year = 2013,
                    Director = "Marc Forster",
                    Rating = "PG-13",
                    Edited = false,
                    Lent_To = null,
                    Notes = "This is my most favorite"
                }
            );
        }
    }
}
