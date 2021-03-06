﻿using System;
using Barista.Contracts.Commands.Product;

namespace Barista.Api.Commands.Product
{
    public class UpdateProduct : IUpdateProduct
    {
        public UpdateProduct(Guid id, string displayName, decimal? recommendedPrice)
        {
            Id = id;
            DisplayName = displayName;
            RecommendedPrice = recommendedPrice;
        }

        public Guid Id { get; }
        public string DisplayName { get; }
        public decimal? RecommendedPrice { get; }
    }
}
