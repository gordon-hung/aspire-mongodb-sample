using Aspire.MongoDBSample.Core;
using Aspire.MongoDBSample.Repositories;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddMongoDBSampleRepository(
		this IServiceCollection services)
		=> services
		.AddSingleton(TimeProvider.System)
		.AddScoped<IUserIdGenerator, UserIdGenerator>()
		.AddScoped<IPasswordHasher, PasswordHasher>()
		.AddTransient<IUserRepository, UserRepository>();
}
