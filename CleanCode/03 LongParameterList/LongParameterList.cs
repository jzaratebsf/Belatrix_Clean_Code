
using System;
using System.Collections.Generic;

namespace CleanCode.LongParameterList
{
    public class LongParameterList
    {
        public class ReservationDateRange
        {
            public DateTime DateFrom { get; set; }
            public DateTime DateTo { get; set; }
        }

        public class Location
        {     
            public int LocationId { get; set; }
            public LocationType LocationType { get; set; }        
        }
        
        public IEnumerable<Reservation> GetReservations(ReservationDateRange reservationDateRange, Location LocationInfo, User user, int? CustomerId= null)
        {

            if (reservationDateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (reservationDateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> GetUpcomingReservations(ReservationDateRange reservationDateRange, User user, Location LocationInfo)
        {
            if (reservationDateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (reservationDateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        private static Tuple<DateTime, DateTime> GetReservationDateRange(ReservationDateRange reservationDateRange, ReservationDefinition sd)
        {
            if (reservationDateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (reservationDateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public void CreateReservation(ReservationDateRange reservationDateRange, Location LocationInfo)
        {
            if (reservationDateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (reservationDateRange.DateTo <= DateTime.Now)
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
