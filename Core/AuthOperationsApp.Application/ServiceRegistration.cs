using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.Utilities.Results.Abstract;
using AuthOperationsApp.Application.Utilities.Results.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace AuthOperationsApp.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection collection, ConfigurationManager _configurationManager)
        {
            ApplicationConfig.ConfigureAutoMapper(collection);
            _configurationManager.GetSection("FilePathSettings");

        }
       
    }
}
