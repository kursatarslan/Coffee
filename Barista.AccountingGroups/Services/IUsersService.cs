﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using RestEase;

namespace Barista.AccountingGroups.Services
{
    [SerializationMethods(Query = QuerySerializationMethod.Serialized)]
    public interface IUsersService
    {
        [AllowAnyStatusCode]
        [Head("api/users/{userId}")]
        Task<HttpResponseMessage> StatUser([Path] Guid userId);
    }
}
