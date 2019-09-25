using RentCar.Core.Abstractions;
using System.Data.Entity.ModelConfiguration;

namespace RentCar.Infrastructure.Abstractions
{
    internal abstract class EntityConfiguration<TEntity> : EntityTypeConfiguration<TEntity>
         where TEntity : Entity
    {
        public EntityConfiguration()
        {
            HasKey(k => k.Id);
            Property(x => x.CreatedDate).HasColumnType("datetime2");
            Property(x => x.ModifiedDate).HasColumnType("datetime2");

        }
    }
}
