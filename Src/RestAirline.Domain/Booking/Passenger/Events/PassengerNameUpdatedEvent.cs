using EventFlow.Aggregates;
using EventFlow.EventStores;

namespace RestAirline.Domain.Booking.Events
{
    [EventVersion("PassengerNameUpdated", 1)]
    public class PassengerNameUpdatedEvent : AggregateEvent<Booking, BookingId>
    {
        public string PassengerKey { get; }
        public string Name { get; }

        public PassengerNameUpdatedEvent(string passengerKey, string name)
        {
            PassengerKey = passengerKey;
            Name = name;
        }
    }
}