using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext>options):base(options)
        {

        }
        public DbSet<MovieDetails> movieDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieDetails>().HasData(
                new MovieDetails() { MovieId = 1, MovieName = "Heriditary", MovieGenre = "Horror", Director = "Ari Aster", Price = 150 },
                new MovieDetails() { MovieId = 2, MovieName = "Midsommar", MovieGenre = "Horror", Director = "Ari Aster", Price = 250 },
                new MovieDetails() { MovieId = 3, MovieName = "Tick,Tick...Boom!", MovieGenre = "Horror", Director = "Lin-Manuel Miranda", Price = 350 });
        }
    }
}
