using MediatR;

namespace Aspire.MongoDBSample.Core.ApplicationServices;
public record UserAddRequest(
	string Username,
	string Password) : IRequest<string>;
