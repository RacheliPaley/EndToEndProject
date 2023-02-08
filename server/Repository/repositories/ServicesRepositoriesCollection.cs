using Microsoft.Extensions.DependencyInjection;
using Repository.entities;
using Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.repositories
{
    public  static class ServicesRepositoriesCollection
    {

        public static void AddRepository(this IServiceCollection service)
        {
            service.AddScoped<IDataRepository<User>, UserRepository>();
            service.AddScoped<IDataRepository<Child>, ChildRepository>();
            
            
        }
    }
}
