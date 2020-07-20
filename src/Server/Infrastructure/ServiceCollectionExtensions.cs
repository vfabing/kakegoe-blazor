using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace KakegoeBlazor.Server.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureContext(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddDbContext<KakegoeBlazorContext>(builder => builder.UseInMemoryDatabase("kakegoe-blazor"));

            return services;
        }
    }
}
