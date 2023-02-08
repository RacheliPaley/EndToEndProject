using Common.DTO_s;
using DBContext;
using Microsoft.Extensions.DependencyInjection;
using Repository.repositories;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class ServiceCollectionExtention
    {

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepository();
            services.AddScoped<IService<UserDTO>, UserService>();

            services.AddScoped<IService<ChildDTO>, ChildService>();

            

            services.AddSingleton<Icontext, Context>();
            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
