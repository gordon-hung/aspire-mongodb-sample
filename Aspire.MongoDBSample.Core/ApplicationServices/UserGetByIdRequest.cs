using MediatR;

namespace Aspire.MongoDBSample.Core.ApplicationServices;
public record UserGetByIdRequest(
	string Id) : IRequest<UserInfoResponse?>;
