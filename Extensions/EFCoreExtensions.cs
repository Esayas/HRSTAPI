using HRSTAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HRSTAPI.Extensions
{
    public static class EFCoreExtensions
    {
        public static IServiceCollection InjectDbContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<HrstContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DevConnection")));
            return services;
        }
    }
}
