using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Aspire.MongoDBSample.Core.ApplicationServices;

namespace Aspire.MongoDBSample.Core.ApplicationServices;
public record UserGetByUsernameRequest(
	string Username) : IRequest<UserInfoResponse?>;
