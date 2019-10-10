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
using RentCar.UI.MappingsProfiles;
using System.Reflection;
using RentCar.Core.Abstractions;
using System.Linq;
using RentCar.Infrastructure.Abstractions;

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

            var repositoryRegistrations =
                from type in typeof(CarRepository<>).Assembly.GetExportedTypes()
                where type.Namespace.StartsWith("RentCar.Infrastructure.Repositories")
                select new { Interfaces = type.GetInterfaces().Where(x => x.Name.Contains("Repository")), Implementacion = type}
                ;

            foreach (var registration in repositoryRegistrations)
            {
                foreach (var @interface in registration.Interfaces)
                {
                    Type concreteRepository = registration.Implementacion.MakeGenericType(typeof(RentCarContext));

                    Container.Register(@interface, concreteRepository, Lifestyle.Singleton);
                }
            }
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
            Container.Register<IEntityService<Car>, CarService>(Lifestyle.Singleton);
            Container.Register<IEntityService<CarInspection>, CarInspectionService>(Lifestyle.Singleton);
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
            Container.Register<FrmClient>(Lifestyle.Singleton);
            Container.Register<FrmCar>(Lifestyle.Singleton);
            Container.Register<FrmCarInspection>(Lifestyle.Singleton);
        }

        private static void ConfigureMaps()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddMaps(typeof(CarBrandProfile).Assembly);
            });

            mapper = config.CreateMapper();
            Container.Register(() => mapper, Lifestyle.Singleton);        
        }
    }
}
