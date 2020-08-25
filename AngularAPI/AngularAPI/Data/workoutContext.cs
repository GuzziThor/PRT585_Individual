using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AngularAPI.Models;

    public class workoutContext : DbContext
    {
        public workoutContext (DbContextOptions<workoutContext> options)
            : base(options)
        {
        }

        public DbSet<Workout> Workout { get; set; }
    }
