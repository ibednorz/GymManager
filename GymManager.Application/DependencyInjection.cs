﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace GymManager.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());

        return services;
    }
}

