using System;
using KakegoeBlazor.Server.Application.Songs.Queries.GetSongs;
using Microsoft.Extensions.DependencyInjection;

namespace KakegoeBlazor.Server.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureApplication(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddTransient<GetSongsQueryHandler>();

            return services;
        }
    }
}
