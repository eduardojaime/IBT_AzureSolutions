using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentsAPI.Models;

namespace StudentsAPI.Data
{
    // extend from DbContext base class
    public class ApplicationDbContext : DbContext
    {
        // Add dbsets
        public DbSet<Student> Students { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
    }
}
