using fs.Jealje.Dominio.Repositorios;
using fs.Jealje.Infraestructura.Datos;
using fs.Jealje.Infraestructura.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddJealjeServices(this IServiceCollection services)
        {
            //Repositorios
            services.AddTransient<IVehiculoRepositorio, VehiculoRepositorio>();

            //DAL
            services.AddTransient<IVehiculoDAL, VehiculoDAL>();

            return services;
        }
    }
}
