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
        public DbSet<CarCategory> CarCategories { get; set; }
        public DbSet<FluelCategory> FluelCategoyries { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<PersonType> PersonTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(typeof(CarBrandEntityTypeConfiguration).Assembly);
        }
    }
}
