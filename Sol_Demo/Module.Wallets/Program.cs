using Microsoft.Extensions.DependencyInjection;

namespace Module.Wallets;

public static class Program
{
    public static void AddWalletModule(this IServiceCollection services)
    {
        services.AddControllers();

        services.AddMediatR((config) =>
        {
            config.RegisterServicesFromAssemblyContaining(typeof(Program));
        });
    }
}