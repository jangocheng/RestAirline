﻿using System;

namespace RestAirline.Api.Domain.Shared
{
    public class AirportTransfer
    {
        public DateTime PickupTime { get; set; }

        public string Address { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}