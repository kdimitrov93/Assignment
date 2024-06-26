﻿using Assignment.Application.Common.Interfaces;
using Assignment.Infrastructure.Data;
using Caliburn.Micro;
using Microsoft.Extensions.DependencyInjection;

namespace Assignment.UI;

public static class DependencyInjection
{
    public static IServiceCollection AddUIServices(this IServiceCollection services)
    {
        return services.AddTransient<IUser, CurrentUser>()
            .AddTransient<IWindowManager, WindowManager>()
            .AddTransient<MainViewModel>()
            .AddTransient<TodoManagmentViewModel>()
            .AddTransient<WeatherForecastViewModel>()
            .AddTransient<IApplicationDbContext, ApplicationDbContext>();
    }
}
