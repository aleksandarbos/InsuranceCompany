using AspNetCoreSPA.DAL;
using AspNetCoreSPA.Model.POCOs;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreSPA
{
    public static class ServiceCollectionExtension
    {
        public static void AddDALTier(this IServiceCollection services)
        {
            services.AddTransient<IRepository<Client>, Repository<Client>>();
            services.AddTransient<IRepository<Car>, Repository<Car>>();
            services.AddTransient<IRepository<Country>, Repository<Country>>();
            services.AddTransient<IRepository<AgeGroup>, Repository<AgeGroup>>();
            services.AddTransient<IRepository<Coefficient>, Repository<Coefficient>>();
            services.AddTransient<IRepository<Continent>, Repository<Continent>>();
            services.AddTransient<IRepository<Destination>, Repository<Destination>>();
            services.AddTransient<IRepository<Home>, Repository<Home>>();
            services.AddTransient<IRepository<InsurancePackage>, Repository<InsurancePackage>>();
            services.AddTransient<IRepository<ItemsOfPackage>, Repository<ItemsOfPackage>>();
            services.AddTransient<IRepository<Pdv>, Repository<Pdv>>();
            services.AddTransient<IRepository<Policy>, Repository<Policy>>();
            services.AddTransient<IRepository<Pricelist>, Repository<Pricelist>>();
            services.AddTransient<IRepository<RateOfPdv>, Repository<RateOfPdv>>();
            services.AddTransient<IRepository<Risk>, Repository<Risk>>();
            services.AddTransient<IRepository<RiskOfCar>, Repository<RiskOfCar>>();
            services.AddTransient<IRepository<RiskOfHouse>, Repository<RiskOfHouse>>();
            services.AddTransient<IRepository<SubjectOfInsurance>, Repository<SubjectOfInsurance>>();
            services.AddTransient<IRepository<TravelActivityTravelPurpose>, Repository<TravelActivityTravelPurpose>>();
            services.AddTransient<IRepository<TravelPurpose>, Repository<TravelPurpose>>();
            services.AddTransient<IRepository<TypeOfPackage>, Repository<TypeOfPackage>>();
        }
    }
}
