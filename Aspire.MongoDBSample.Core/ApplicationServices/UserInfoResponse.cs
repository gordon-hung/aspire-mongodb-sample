using Aspire.MongoDBSample.Core.Enums;

namespace Aspire.MongoDBSample.Core.ApplicationServices;
public record UserInfoResponse(
	string Id,
	string Username,
	UserState State,
	DateTimeOffset CreatedAt,
	DateTimeOffset UpdateAt);
