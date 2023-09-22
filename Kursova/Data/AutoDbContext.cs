using Kursova.Data.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursova.Data
{
    public class AutoDbContext : DbContext
    {
        public DbSet<Auto> Autos { get; set; }
        public DbSet<Color> Colors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-H42B83O\\SQLEXPRESS;Initial Catalog=AutoDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Color>().HasData(new[]
            {
                new Color(1,"Blue"),
                new Color(2,"Yellow"),
                new Color(3,"Gray"),
                new Color(4,"White"),
                new Color(5,"Black"),
                new Color(6,"Green"),
                new Color(7,"Red")
            });
            modelBuilder.Entity<Auto>().HasData(new[]
            {
                new Auto(1,"Audi","80",2500,1978,3),
                new Auto(2,"Mazda","RX7",2300,1978,1),
                new Auto(3,"Toyota","Land Cruiser",7000,2017,2),
                new Auto(4,"ZAZ-1103","Slavuta",1500,1988,5),
                new Auto(5,"BMW","X5",5000,1999,4)
            }); 
        }
    }
}
