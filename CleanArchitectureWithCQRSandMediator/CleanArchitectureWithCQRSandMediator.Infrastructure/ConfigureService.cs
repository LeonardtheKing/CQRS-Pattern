using AutoMapper;
using CleanArchitectureWithCQRSandMediator.Domain.Repository;
using CleanArchitectureWithCQRSandMediator.Infrastructure.Data;
using CleanArchitectureWithCQRSandMediator.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediator.Infrastructure
{
    public static class ConfigurationService
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<BlogDbContext>(options =>
            {
              options.UseSqlite(configuration.GetConnectionString("ConnectionString")
                    ?? throw new InvalidOperationException("Connection string not found"));
            });
            services.AddTransient<IBlogRepository, BlogRepository>();
            return services;
        }
    }
}
