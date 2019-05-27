﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using Barista.Common.Tests;
using Barista.StockOperations.Services;
using Barista.StockOperations.Verifiers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Barista.StockOperations.Tests.Verifiers
{
    [TestClass]
    public class UserVerifierTests : VerifierAcceptingGuidTestBase<IUsersService>
    {
        private IUserVerifier Verifier => new UserVerifier(ServiceMock.Object);

        protected override async Task InvokeVerifier(Guid resourceId, Task<HttpResponseMessage> responseMsgTask)
        {
            ServiceMock.Setup(svc => svc.StatUser(resourceId)).Returns(responseMsgTask).Verifiable();
            await Verifier.AssertExists(resourceId);
        }

        protected override void VerifyExpectations(Guid resourceId)
        {
            ServiceMock.Verify(svc => svc.StatUser(resourceId));
        }
    }
}
