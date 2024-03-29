﻿using RentCar.Core.Entities;
using RentCar.Infrastructure.Abstractions;
using System.Data.Entity;

namespace RentCar.Infrastructure.Repositories
{
    public class CarCategoryRepository<TDbContext> : Repository<TDbContext, CarCategory> where TDbContext : DbContext
    {
        public CarCategoryRepository(TDbContext dbContext) : base(dbContext)
        {

        }
    }
}
