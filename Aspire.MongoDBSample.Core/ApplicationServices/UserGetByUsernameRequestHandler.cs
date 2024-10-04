using MediatR;
using Aspire.MongoDBSample.Core.ApplicationServices;

namespace Aspire.MongoDBSample.Core.ApplicationServices;
internal class UserGetByUsernameRequestHandler(
	IUserRepository repository) : IRequestHandler<UserGetByUsernameRequest, UserInfoResponse?>
{
	public async Task<UserInfoResponse?> Handle(UserGetByUsernameRequest request, CancellationToken cancellationToken)
	{
		var info = await repository.GetByUsernameAsync(request.Username.ToLower(), cancellationToken).ConfigureAwait(false);

		return info is null
			? null
			: new UserInfoResponse(
				info.Id,
				info.Username,
				info.State,
				info.CreatedAt,
				info.UpdateAt);
	}
}
