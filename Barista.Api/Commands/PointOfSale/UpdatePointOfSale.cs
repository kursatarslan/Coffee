﻿using System;
using Barista.Contracts.Commands.PointOfSale;

namespace Barista.Api.Commands.PointOfSale
{
    public class UpdatePointOfSale : IUpdatePointOfSale
    {
        public UpdatePointOfSale(Guid id, string displayName, Guid parentAccountingGroupId, Guid? saleStrategyId, string[] features)
        {
            Id = id;
            DisplayName = displayName;
            ParentAccountingGroupId = parentAccountingGroupId;
            SaleStrategyId = saleStrategyId;
            Features = features ?? new string[0];
        }

        public Guid Id { get; }
        public string DisplayName { get; }
        public Guid ParentAccountingGroupId { get; }
        public Guid? SaleStrategyId { get; }
        public string[] Features { get; }
    }
}
