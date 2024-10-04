using MediatR;
using Aspire.MongoDBSample.Core.ApplicationServices;

namespace Aspire.MongoDBSample.Core.ApplicationServices;
public record UserGetByIdRequest(
	string Id):IRequest<UserInfoResponse?>;
