using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decanate
{
    public class DataContext : DbContext
    {
        public DataContext() : base()
        {

        }

        public DbSet<Decanates> Decanates { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Evaluations> Evaluations { get; set; }
        public DbSet<PayFlows> PayFlows { get; set; }
        public DbSet<Infos> Infos { get; set; }
        public DbSet<Profiles> Profiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseMySql("server=localhost;user=root;password=root;database=test",
                new MySqlServerVersion(new Version(10, 3, 0)));
        }
    }
}
