﻿using System;

namespace Barista.Operations.Tracking
{
    public interface RoutingSlipCreated
    {
        /// <summary>
        /// The tracking number of the routing slip
        /// </summary>
        Guid TrackingNumber { get; }

        /// <summary>
        /// The time the routing slip was created
        /// </summary>
        DateTime Timestamp { get; }
    }
}
