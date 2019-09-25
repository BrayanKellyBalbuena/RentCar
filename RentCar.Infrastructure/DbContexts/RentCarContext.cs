using RentCar.Core.Entities;
using RentCar.Infrastructure.Constants;
using RentCar.Infrastructure.EntitiesConfigutations;
using System.Data.Entity;

namespace RentCar.Infrastructure.DbContexts
{
    public class RentCarContext : DbContext
   {
        public RentCarContext() : base(DbConstants.DATABASE)
        {
            Database.SetInitializer<RentCarContext>(null);
        }

        public DbSet<CarBrand> CarBrands { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(typeof(CarBrandEntityTypeConfiguration).Assembly);
        }
    }
}
