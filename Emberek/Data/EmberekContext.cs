using Emberek.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emberek.Data
{
    public class EmberekContext:DbContext
    {
        public DbSet<Ember> Emberek { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EmberNyilvantartas;Trusted_Connection=true");
        }
    }
}
