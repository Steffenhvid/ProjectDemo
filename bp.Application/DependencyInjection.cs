using bp.Application.Interfaces;
using bp.Application.UseCases.Math;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static bp.Application.UseCases.Math.AddTwoNumbers;

namespace bp.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddUseCases();
            return services;
        }

        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddTransient<IUseCase<AddTwoNumbersInput, int>, AddTwoNumbers>();
            return services;
        }
    }
}
