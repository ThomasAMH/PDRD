using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PDRD.Models;

namespace PDRD.Data
{
    public class PDRDContext : DbContext
    {
        public PDRDContext (DbContextOptions<PDRDContext> options)
            : base(options)
        {
        }
        public DbSet<Hymn> Hymns { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Talk> Talks { get; set; }
        public DbSet<PDRD.Models.Agenda> Agenda { get; set; } = default!;
        public DbSet<PDRD.Models.Hymn> Hymn { get; set; } = default!;

        public DbSet<PDRD.Models.Person> Person { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Entity configurations and relationships
            // Define relationships using modelBuilder.Entity<T>()
            // Configure entity mappings and relationships using Fluent API
        }
    }
}
