
using System;
using System.Collections.Generic;

namespace CleanCode.LongParameterList
{
    public class LongParameterList
    {
        public class ReservationInputParameter
        {
            public DateTime DateFrom { get; set; }
            public DateTime DateTo { get; set; }
            public User User { get; set; }
            public int LocationId { get; set; }
            public LocationType LocationType { get; set; }
            public int? CustomerId { get; set; }
        }


        public IEnumerable<Reservation> GetReservations( ReservationInputParameter reservationinformation )
        {

            if (reservationinformation.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (reservationinformation.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> GetUpcomingReservations(ReservationInputParameter reservationinformation)
        {
            if (reservationinformation.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (reservationinformation.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        private static Tuple<DateTime, DateTime> GetReservationDateRange(ReservationInputParameter reservationinformation, ReservationDefinition sd)
        {
            if (reservationinformation.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (reservationinformation.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public void CreateReservation(ReservationInputParameter reservationinformation)
        {
            if (reservationinformation.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (reservationinformation.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }
    }

    internal class ReservationDefinition
    {
    }

    public class LocationType
    {
    }

    public class User
    {
        public object Id { get; set; }
    }

    public class Reservation
    {
    }
}
