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
        }
    }
}
