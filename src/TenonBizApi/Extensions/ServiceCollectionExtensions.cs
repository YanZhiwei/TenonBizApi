using Tenon.AspNetCore.OpenApi.Extensions;
using Tenon.FluentValidation.AspNetCore.Extensions;

namespace TenonBizApi.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddWebApiCoreFeatures(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddScalarOpenApi(configuration.GetSection("ScalarUI"));
        services.AddWebApiFluentValidation(configuration.GetSection("FluentValidation"),typeof(Program).Assembly);
    }
}