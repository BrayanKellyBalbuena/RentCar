using RentCar.Core.Entities;
using RentCar.Core.Interfaces;
using RentCar.Core.Interfaces.Domain;
using RentCar.Infrastructure.DbContexts;
using RentCar.Infrastructure.Repositories;
using RentCar.Infrastructure.Services;
using RentCar.UI.Maintenances;
using SimpleInjector;
using System;
using System.Windows.Forms;
using AutoMapper;
using RentCar.UI.ViewModels;
using RentCar.UI.MappingsProfiles;

namespace RentCar.UI
{
    
    static class Program
    {
        public static Container Container { get; private set; }
        public static IMapper mapper;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(Container.GetInstance<MasterPage>());
        }

        private static void Bootstrap()
        {
            Container = new Container();
            Container.Register<RentCarContext>(Lifestyle.Singleton);

            RegisterRepositories();
            RegisterServices();
            RegisterForms();
            ConfigureMaps();
        }

        private static void RegisterRepositories()
        {

            Container.Register<IRepository<CarBrand>, CarBrandRepository<RentCarContext>>(Lifestyle.Singleton);
            Container.Register<IRepository<CarCategory>, CarCategoryRepository<RentCarContext>>(Lifestyle.Singleton);
            Container.Register<IRepository<FluelCategory>, FluelCategoryRepository<RentCarContext>>(Lifestyle.Singleton);
            Container.Register<IRepository<CarModel>, CarModelRepository<RentCarContext>>(Lifestyle.Singleton);
            Container.Register<IRepository<PersonType>, PersonTypeRepository<RentCarContext>>(Lifestyle.Singleton);
            Container.Register<IRepository<Employee>, EmployeeRepository<RentCarContext>>(Lifestyle.Singleton);
            Container.Register<IRepository<Client>, ClientRepository<RentCarContext>>(Lifestyle.Singleton);
            
        }

        private static void RegisterServices()
        {
            Container.Register<IEntityService<CarBrand>, CarBrandService>(Lifestyle.Singleton);
            Container.Register<IEntityService<CarCategory>, CarCategoryService>(Lifestyle.Singleton);
            Container.Register<IEntityService<FluelCategory>, FuelCategoryService>(Lifestyle.Singleton);
            Container.Register<IEntityService<CarModel>, CarModelService>(Lifestyle.Singleton);
            Container.Register<IEntityService<PersonType>, PersonTypeService>(Lifestyle.Singleton);
            Container.Register<IEntityService<Employee>, EmployeeService>(Lifestyle.Singleton);
            Container.Register<IEntityService<Client>, ClientService>(Lifestyle.Singleton);
        }

        private static void RegisterForms()
        {
            Container.Register<MasterPage>(Lifestyle.Singleton);
            Container.Register<FrmCarBrand>(Lifestyle.Singleton);
            Container.Register<FrmCarCategory>(Lifestyle.Singleton);
            Container.Register<FrmFluelCategory>(Lifestyle.Singleton);
            Container.Register<FrmCarModel>(Lifestyle.Singleton);
            Container.Register<FrmPersonType>(Lifestyle.Singleton);
            Container.Register<FrmEmployee>(Lifestyle.Singleton);
        }

        private static void ConfigureMaps()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddMaps(typeof(CarBrandProfile).Assembly);
            });

            mapper = config.CreateMapper();
        }
    }
}
