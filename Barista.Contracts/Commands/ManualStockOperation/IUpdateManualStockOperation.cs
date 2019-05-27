﻿using System;

namespace Barista.Contracts.Commands.ManualStockOperation
{
    public interface IUpdateManualStockOperation : ICommand
    {
        Guid Id { get; }
        Guid StockItemId { get; }
        decimal Quantity { get; }
        Guid CreatedByUserId { get; }
        string Comment { get; }
    }
}
