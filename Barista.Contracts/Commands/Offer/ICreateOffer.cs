﻿using System;

namespace Barista.Contracts.Commands.Offer
{
    public interface ICreateOffer : ICommand
    {
        Guid Id { get; }
        Guid PointOfSaleId { get; }
        Guid ProductId { get; }
        decimal? RecommendedPrice { get; }
        Guid? StockItemId { get; }
        DateTimeOffset? ValidSince { get; }
        DateTimeOffset? ValidUntil { get; }
    }
}
