﻿using System;
using System.ComponentModel.DataAnnotations;

namespace RestAirline.ReadModel.EntityFramework.Booking
{
    public class Journey
    {
        [Key]
        public string Id { get; set; }

        public string JourneyKey { get; set; }

        public DateTime DepartureDate { get; set; }

        public string DepartureStation { get; set; }

        public DateTime ArriveDate { get; set; }

        public string ArriveStation { get; set; }

        public string Description { get; set; }

//        public Flight Flight { get; set; }
        
        public BookingReadModel BookingReadModel { get; set; }
        
        public string BookinglId { get; set; }
    }

    public static class JourneyMapper
    {
        public static Journey ToReadModel(this Domain.Booking.Trip.Journey journey)
        {
            var model = new Journey
            {
                Id=journey.JourneyKey,
//                Flight = journey.Flight.ToReadModel(),
                ArriveDate = journey.ArriveDate,
                DepartureDate = journey.DepartureDate,
                ArriveStation = journey.ArriveStation,
                DepartureStation = journey.DepartureStation,
                Description = journey.Description,
                JourneyKey = journey.JourneyKey
            };

            return model;
        }
    }
}