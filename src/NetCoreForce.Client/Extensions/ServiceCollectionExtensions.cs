using Microsoft.Extensions.DependencyInjection;

namespace NetCoreForce.Client.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSalesforce(this IServiceCollection services)
        {
            services.AddHttpClient<ForceClient>(client =>
            {
                client.DefaultRequestHeaders.Add("X-PrettyPrint", "1");
            });
            
            services.AddHttpClient<AuthenticationClient>(client =>
            {
                client.DefaultRequestHeaders.Add("X-PrettyPrint", "1");
            });

            return services;
        }
    }
}
