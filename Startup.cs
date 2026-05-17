using Google.Cloud.Functions.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PontoFunction;

[assembly: FunctionsStartup(typeof(Startup))]

namespace PontoFunction;

public class Startup : FunctionsStartup
{
    public override void ConfigureServices(WebHostBuilderContext context, IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
    }
}