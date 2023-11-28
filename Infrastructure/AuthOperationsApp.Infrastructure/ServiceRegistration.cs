using FluentValidation;
using Microsoft.Extensions.DependencyInjection;


namespace AuthOperationsApp.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
           
            //services.AddScoped<IValidator<LoginUserCommandRequest>, LoginUserValidator>();

        }
    }
}
