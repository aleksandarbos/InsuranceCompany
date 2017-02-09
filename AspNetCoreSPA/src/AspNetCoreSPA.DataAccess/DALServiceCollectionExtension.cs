using AspNetCoreSPA.DAL;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreSPA
{
    public static class DALServiceCollectionExtension
    {
        public static void AddDALTier(this IServiceCollection services)
        {
            services.AddTransient<ICountryDAL, CountryDAL>();
            services.AddTransient<IAgeGroupDAL, AgeGroupDAL>();
            services.AddTransient<ICoefficientDAL, CoefficientDAL>();
            services.AddTransient<IContinentDAL, ContinentDAL>();
            services.AddTransient<IDestinationDAL, DestinationDAL>();
            services.AddTransient<IHomeDAL, HomeDAL>();
            services.AddTransient<IInsurancePackageDAL, InsurancePackageDAL>();
            services.AddTransient<IItemsOfPackageDAL, ItemsOfPackageDAL>();
            services.AddTransient<IPdvDAL, PdvDAL>();
            services.AddTransient<IPolicyDAL, PolicyDAL>();
            services.AddTransient<IPricelistDAL, PricelistDAL>();
            services.AddTransient<IRateOfPdvDAL, RateOfPdvDAL>();
            services.AddTransient<IRiskDAL, RiskDAL>();
            services.AddTransient<IRiskOfCarDAL, RiskOfCarDAL>();
            services.AddTransient<IRiskOfHouseDAL, RiskOfHouseDAL>();
            services.AddTransient<ISubjectOfInsuranceDAL, SubjectOfInsuranceDAL>();
            services.AddTransient<ITravelActivityTravelPurposeDAL, TravelActivityTravelPurposeDAL>();
            services.AddTransient<ITravelPurposeDAL, TravelPurposeDAL>();
            services.AddTransient<ITypeOfPackageDAL, TypeOfPackageDAL>();
        }
    }
}
