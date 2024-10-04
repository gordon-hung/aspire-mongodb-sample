﻿using Aspire.MongoDBSample.Core.ApplicationServices;
using Aspire.MongoDBSample.Core.Enums;
using Aspire.MongoDBSample.Core.Models;
using NSubstitute;

namespace Aspire.MongoDBSample.Core.UnitTest.ApplicationServices;

public class UserGetByIdRequestHandlerUnitTest
{
	[Fact]
	public async Task Normal_Process()
	{
		var fakeRepository = Substitute.For<IUserRepository>();

		var request = new UserGetByIdRequest(
			Id: "4uo9qvf7jdpe");

		var info = new UserInfo(
			Id: "4uo9qvf7jdpe",
			Username: "gordon_hung",
			Password: "$2a$10$6y8BGUE0MI9caEF5xH0i6un0G7Gb2lzFFRNfGzSoY50sxjIws./NO",
			State: UserState.Enable,
			CreatedAt: DateTimeOffset.UtcNow,
			UpdateAt: DateTimeOffset.UtcNow);
		_ = fakeRepository.GetByIdAsync(
			id: Arg.Is(request.Id.ToLower()),
			cancellationToken: Arg.Any<CancellationToken>())
			.Returns(info);

		var sut = new UserGetByIdRequestHandler(
			fakeRepository);

		var cancellationTokenSource = new CancellationTokenSource();
		var token = cancellationTokenSource.Token;

		var actual = await sut.Handle(request, token);

		Assert.NotNull(actual);
		Assert.Equal(request.Id, actual.Id);
		Assert.Equal(info.Username, actual.Username);
		Assert.Equal(info.State, actual.State);
		Assert.Equal(info.CreatedAt, actual.CreatedAt);
		Assert.Equal(info.UpdateAt, actual.UpdateAt);
	}
}
