using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class RentACarContext: DbContext
    {
        // projenin hangi veri tabanı ile ilişkili olduğunu belirttiğimiz yer.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"\Server=(localdb)\MSSQLLocalDB;Database=RentACar;Trusted_Connection=true");
        }

        // DbSet: hangi tabloya ne karşılık gelecek onu belirtiyoruz.
        public DbSet<Car>  Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}
