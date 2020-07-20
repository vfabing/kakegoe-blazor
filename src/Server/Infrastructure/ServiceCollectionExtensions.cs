using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace KakegoeBlazor.Server.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static async Task<IServiceCollection> ConfigureContextAsync(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddDbContext<KakegoeBlazorContext>(builder => builder.UseInMemoryDatabase("kakegoe-blazor"));

            await DataHelper.SeedAsync(services.BuildServiceProvider().GetService<KakegoeBlazorContext>());

            return services;
        }
    }
}
