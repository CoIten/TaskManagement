﻿using ApplicationCore.Interfaces.Repos;
using ApplicationCore.Interfaces.Services;
using ApplicationCore.Services.Implementations;
using Infrastructure.Implementations;

namespace TaskManagementSystem
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddInfraStructureServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAssignmentRepository, AssignmentRepository>();
            services.AddScoped<IUserAssignmentRepository, UserAssignmentRepository>();
            return services;
        }

        public static IServiceCollection AddApplicationCoreServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAssignmentService, AssignmentService>();
            services.AddScoped<IUserAssignmentService, UserAssignmentService>();
            return services;
        }
    }
}
