using Microsoft.EntityFrameworkCore;
using MovieTheatre._00Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTheatre.Models
{
    public class MovieDBContext : DbContext
    {

      
            public MovieDBContext(DbContextOptions<MovieDBContext> options) : base(options)
            {


            }
            public DbSet<Movie> Movies { get; set; }
            public DbSet<Category> Category { get; set; }


    }
}
