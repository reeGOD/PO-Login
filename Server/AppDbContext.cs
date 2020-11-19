using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Login.Shared.Models;

namespace Login.Server
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // This here is a list for all the tables that will be in the DB
        public DbSet<User> Users { get; set; }

        // Managing the DB
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(
                    new User
                    {
                        UserId = 1,
                        Email = "gabriel@admin.com",
                        Password = "admin",
                        Name = "Gabriel Admin",
                        Role = 1
                    },

                    new User
                    {
                        UserId = 2,
                        Email = "gustavo@teste.com",
                        Password = "aviao",
                        Name = "gustavo",
                        Role = 3
                    },

                    new User
                    {
                        UserId = 3,
                        Email = "joao@teste.com",
                        Password = "aviao",
                        Name = "henrique",
                        Role = 3
                    }
                );
        }
    }
}
