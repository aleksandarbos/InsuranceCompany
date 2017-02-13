using AspNetCoreSPA.BLL;
using AspNetCoreSPA.BLL.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreSPA
{
    public static class BusinessServiceCollectionExtensions
    {
        public static void AddBusinessTier(this IServiceCollection services)
        {

            services.AddTransient<IClientBLL, ClientBLL>();
            services.AddTransient<ICarBLL, CarBLL>();
            services.AddTransient<ICountryBLL, CountryBLL>();
            services.AddTransient<IAgeGroupBLL, AgeGroupBLL>();
            services.AddTransient<ICoefficientBLL, CoefficientBLL>();
            services.AddTransient<IContinentBLL, ContinentBLL>();
            services.AddTransient<IDestinationBLL, DestinationBLL>();
            services.AddTransient<IHomeBLL, HomeBLL>();
            services.AddTransient<IInsurancePackageBLL, InsurancePackageBLL>();
            services.AddTransient<IItemsOfPackageBLL, ItemsOfPackageBLL>();
            services.AddTransient<IPdvBLL, PdvBLL>();
            services.AddTransient<IPolicyBLL, PolicyBLL>();
            services.AddTransient<IPricelistBLL, PricelistBLL>();
            services.AddTransient<IRateOfPdvBLL, RateOfPdvBLL>();
            services.AddTransient<IRiskBLL, RiskBLL>();
            services.AddTransient<IRiskOfCarBLL, RiskOfCarBLL>();
            services.AddTransient<IRiskOfHouseBLL, RiskOfHouseBLL>();
            services.AddTransient<ISubjectOfInsuranceBLL, SubjectOfInsuranceBLL>();
            services.AddTransient<ITravelActivityTravelPurposeBLL, TravelActivityTravelPurposeBLL>();
            services.AddTransient<ITravelPurposeBLL, TravelPurposeBLL>();
            services.AddTransient<ITypeOfPackageBLL, TypeOfPackageBLL>();
        }
    }
}
