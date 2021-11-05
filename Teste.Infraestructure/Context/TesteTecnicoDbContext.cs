using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities;
using Teste.Infraestructure.Data.Configurantions;

namespace Teste.Infraestructure.Data.Context
{
    public class TesteTecnicoDbContext : DbContext
    {
        public TesteTecnicoDbContext(DbContextOptions<TesteTecnicoDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
        }
    }
}
