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

        public DbSet<AddMovieResponce> responces { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<AddMovieResponce>().HasData(

                new AddMovieResponce
                {
                    MovieId = 1,
                    Category = "Action/Adventure",
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
                    Category = "Action/Adventure",
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
                    Category = "Horor/Action",
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
