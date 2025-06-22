using Microsoft.Extensions.DependencyInjection;

namespace Purchase.Application.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
          
            return services;
        }
    }
}
