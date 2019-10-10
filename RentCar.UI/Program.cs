﻿using RentCar.Infrastructure.DbContexts;
using RentCar.Infrastructure.Repositories;
using RentCar.UI.Maintenances;
using SimpleInjector;
using System;
using System.Windows.Forms;
using AutoMapper;
using RentCar.UI.MappingsProfiles;
using System.Linq;
using RentCar.Infrastructure.Services;

namespace RentCar.UI
{

    static class Program
    {
        public static Container Container { get; private set; }
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
            var serviceRegistrations =
                from type in typeof(CarService).Assembly.GetExportedTypes()
                where type.Namespace.StartsWith("RentCar.Infrastructure.Services")
                select new { Interfaces = type.GetInterfaces().Where(i => i.Name.Contains("Service")), Implementation = type };

            foreach (var registration in serviceRegistrations)
            {
                foreach (var @interface in registration.Interfaces)
                {
                    Container.Register(@interface, registration.Implementation, Lifestyle.Singleton);
                }
            }
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

           var mapper = config.CreateMapper();
            Container.Register(() => mapper, Lifestyle.Singleton);        
        }
    }
}
