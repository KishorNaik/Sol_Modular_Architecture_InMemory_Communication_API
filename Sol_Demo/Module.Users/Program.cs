using Microsoft.Extensions.DependencyInjection;

namespace Module.Users;

public static class Program
{
    public static void AddUserModule(this IServiceCollection services)
    {
        services.AddControllers();

        services.AddMediatR((config) =>
        {
            config.RegisterServicesFromAssemblyContaining(typeof(Program));
        });
    }
}