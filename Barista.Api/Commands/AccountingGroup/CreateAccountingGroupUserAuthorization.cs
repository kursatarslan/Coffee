﻿using System;
using Barista.Contracts.Commands.AccountingGroupUserAuthorization;

namespace Barista.Api.Commands.AccountingGroup
{
    public class CreateAccountingGroupUserAuthorization : ICreateAccountingGroupUserAuthorization
    {
        public CreateAccountingGroupUserAuthorization(Guid accountingGroupId, Guid userId, string level)
        {
            AccountingGroupId = accountingGroupId;
            UserId = userId;
            Level = level;
        }

        public Guid AccountingGroupId { get; }
        public Guid UserId { get; }
        public string Level { get; }
    }
}
