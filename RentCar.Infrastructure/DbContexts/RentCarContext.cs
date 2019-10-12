using RentCar.Core.Entities;
using RentCar.Infrastructure.Constants;
using RentCar.Infrastructure.EntitiesConfigutations;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;

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
        public DbSet<CarInspection> CarsInspections { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(typeof(CarBrandEntityTypeConfiguration).Assembly);
        }

        public override int SaveChanges()
        {
            if (ChangeTracker.HasChanges())
                return base.SaveChanges();
            return 0;
        }

        public override Task<int> SaveChangesAsync()
        {
            if(ChangeTracker.HasChanges())
                return base.SaveChangesAsync();

            return new Task<int>(_ => 0, null);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            if(ChangeTracker.HasChanges())
                 return base.SaveChangesAsync(cancellationToken);
            return new Task<int>(_ => 0, cancellationToken);
        }
    }
}
