using Aspire.MongoDBSample.Core.Enums;

namespace Aspire.MongoDBSample.Core.Models;
public record UserInfo(
	string Id,
	string Username,
	string Password,
	UserState State,
	DateTimeOffset CreatedAt,
	DateTimeOffset UpdateAt);
