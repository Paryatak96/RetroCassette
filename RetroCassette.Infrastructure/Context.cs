using RetroCassette.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetroCassette.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Cassette> Cassettes { get; set; }
        public DbSet<Director> Directors { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
