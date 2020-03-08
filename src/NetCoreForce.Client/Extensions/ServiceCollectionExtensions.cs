using Microsoft.Extensions.DependencyInjection;

namespace NetCoreForce.Client.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSalesforce(this IServiceCollection services)
        {
            services.AddHttpClient<ForceClient>();
            services.AddHttpClient<AuthenticationClient>();
            return services;
        }
    }
}
