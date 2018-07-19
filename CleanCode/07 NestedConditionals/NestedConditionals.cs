using System;

namespace CleanCode.NestedConditionals
{
    public class Customer
    {
        public int LoyaltyPoints { get; set; }
    }

    public class Reservation
    {
        public Reservation(Customer customer, DateTime dateTime)
        {
            From = dateTime;
            Customer = customer;
        }

        public DateTime From { get; set; }
        public Customer Customer { get; set; }
        public bool IsCanceled { get; set; }

        public void Cancel()
        {

            // If reservation already started throw exception
            if (DateTime.Now > From)
            {
                throw new InvalidOperationException("It's too late to cancel.");
            }
            // Gold customers can cancel up to 24 hours before
            if (Customer.LoyaltyPoints > 100)
            {
                if ((From - DateTime.Now).TotalHours < 24)
                {
                    throw new InvalidOperationException("It's too late to cancel.");
                }
                
            }
            else
            {
                // Regular customers can cancel up to 48 hours before
                if ((From - DateTime.Now).TotalHours < 48)
                {
                    throw new InvalidOperationException("It's too late to cancel.");
                }
                
            }
            IsCanceled = true;
        }

    }
}
