using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace PS.Application.Commands
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationCommand(this IServiceCollection services)
        {
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly()); 
            return services;
        }
    }

}
