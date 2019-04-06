using Microsoft.Extensions.DependencyInjection;

namespace SkorBlazor.Storage
{
    public static class StorageExtension
    {
        public static void AddLocalStorage(this IServiceCollection services)
        {
            services.AddScoped<ILocalStorage, LocalStorage>();
        }
    }
}
