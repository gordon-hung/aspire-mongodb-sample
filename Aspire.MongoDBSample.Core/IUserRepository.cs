using Aspire.MongoDBSample.Core.Models;

namespace Aspire.MongoDBSample.Core;

public interface IUserRepository
{
	ValueTask AddAsync(string id, string username, string hashedPassword, CancellationToken cancellationToken = default);

	ValueTask<UserInfo?> GetByUsernameAsync(string username, CancellationToken cancellationToken = default);

	ValueTask<UserInfo?> GetByIdAsync(string id, CancellationToken cancellationToken = default);

	ValueTask UpdatePasswordAsync(string id, string hashedPassword, CancellationToken cancellationToken = default);

	ValueTask InitializationAsync(CancellationToken cancellationToken = default);
}
