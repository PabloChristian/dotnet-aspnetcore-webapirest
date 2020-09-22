using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiREST.Domain.Services;

namespace WebApiREST.Application
{
        public static class DependencyInjection
        {
            public static void RegisterServices(this IServiceCollection services)
            {
                //Mappers

                //Servicos
                services.AddScoped<ProdutoService, ProdutoService>();

                //Repositorios

            }
        }
}
