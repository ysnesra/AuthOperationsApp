using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.Repositories;
using AuthOperationsApp.Persistence.Contexts;
using AuthOperationsApp.Persistence.Repositories;
using AuthOperationsApp.Persistence.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace AuthOperationsApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<AuthOperationsAppDbContext>(options => {
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }, ServiceLifetime.Scoped);

            services.AddHttpContextAccessor();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Repository

            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();

            services.AddScoped<IRoleReadRepository, RoleReadRepository>();
            services.AddScoped<IRoleWriteRepository, RoleWriteRepository>();

            services.AddScoped<IGroupReadRepository, GroupReadRepository>();
            services.AddScoped<IGroupWriteRepository, GroupWriteRepository>();

            services.AddScoped<IRoleGroupReadRepository, RoleGroupReadRepository>();
            services.AddScoped<IRoleGroupWriteRepository, RoleGroupWriteRepository>();

            services.AddScoped<IUserGroupReadRepository, UserGroupReadRepository>();
            services.AddScoped<IUserGroupWriteRepository, UserGroupWriteRepository>();

            // Service

            //services.AddScoped<IResult, Result>();
            //services.AddScoped<IDataResult, DataResult>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<IRoleGroupService, RoleGroupService>();
            services.AddScoped<IUserGroupService, UserGroupService>();
           

        }
    }
}
