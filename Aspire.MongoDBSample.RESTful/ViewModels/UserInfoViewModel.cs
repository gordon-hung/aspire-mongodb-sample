using Aspire.MongoDBSample.Core.Enums;

namespace Aspire.MongoDBSample.RESTful.ViewModels;

public record UserInfoViewModel(
	string Id,
	string Username,
	UserState State,
	DateTimeOffset CreatedAt,
	DateTimeOffset UpdateAt);
