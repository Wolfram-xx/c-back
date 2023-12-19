using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain.Model;

namespace WebApp.Infrastructure 
{
    public class Context : DbContext

    {
        public DbSet<Discipline> Disciplines { get; set; } = null!;
        public DbSet<ExamType> ExamTypes { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;

        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
