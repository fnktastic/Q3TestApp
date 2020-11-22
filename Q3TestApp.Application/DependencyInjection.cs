using MediatR;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Q3TestApp.Application.Common.Behaviours;

namespace Q3TestApp.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));

            return services;
        }
    }
}
