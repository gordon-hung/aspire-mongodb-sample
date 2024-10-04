using Aspire.MongoDBSample.Core;
using Microsoft.Extensions.Hosting;

namespace Aspire.MongoDBSample.Repositories;
public sealed class UserInitStartup(IUserRepository repository) : IHostedService
{
	public async Task StartAsync(CancellationToken cancellationToken)
	{
		await repository.InitializationAsync(
			cancellationToken)
			.ConfigureAwait(false);
	}

	public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
}

