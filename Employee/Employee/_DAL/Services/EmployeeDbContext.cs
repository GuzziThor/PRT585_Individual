using Employee._DAL.Models;
using Employee.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee._DAL.Services
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {


        }
        public DbSet<EmployeeModel> Employees { get; set; }

    }
}
