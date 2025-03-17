using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SharedTravelling.Data;
using System.Runtime.CompilerServices;

namespace Microsoft.Extentions.DependencyInjection;

public static class ServiceCollectionExtention
{
	public static IServiceCollection AddApplicationServices(this IServiceCollection services)
	{
		return services;
	}

	public static IServiceCollection AddApplicatonDbContext(this IServiceCollection services, IConfiguration config)
	{
		var connectionString = config.GetConnectionString("DefaultConnection");
		services.AddDbContext<ApplicationDbContext>(options =>
			options.UseSqlServer(connectionString));

		services.AddDatabaseDeveloperPageExceptionFilter();

		return services;
	}

	public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
	{
		services
			.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
			.AddEntityFrameworkStores<ApplicationDbContext>();

		return services;
	}
}
