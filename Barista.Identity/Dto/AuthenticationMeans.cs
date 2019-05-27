﻿using System;

namespace Barista.Identity.Dto
{
    public class AuthenticationMeansDto
    {
        public Guid Id { get; set; }
        public string Method { get; set; }
        public string Label { get; set; }
        public DateTimeOffset ValidSince { get; set; }
        public DateTimeOffset? ValidUntil { get; set; }
        public bool IsValid => DateTimeOffset.UtcNow > ValidSince && !(ValidUntil < DateTimeOffset.UtcNow);
    }
}
