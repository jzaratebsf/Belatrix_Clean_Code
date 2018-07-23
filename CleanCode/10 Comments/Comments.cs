using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace CleanCode.Comments
{
    public class Comments
    {
        private int _pf;  // rename variable to pay frequency
        private DbContext _dbContext;   //Database Conexion

        public Comments()
        {
            _dbContext = new DbContext();   //Initialize Database Conexion
        }

        // Returns list of customers in a country.
        public List<Customer> GetCustomers(int countryCode)
        {
            //TODO: 
            //GetCustomers method Implementation
            //Specify variable countryCode
            //Implement a message for NotImplementedException

            throw new NotImplementedException();
        }

        public void SubmitOrder(Order order)
        {
            // Save order to the database
            // TODO: Create a method and abstract it in another function outside SubmitOrder
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();

            // Send an email to the customer
            // TODO: Create a method and abstract it in another function outside SubmitOrder
            var client = new SmtpClient();          
            var message = new MailMessage("noreply@site.com", order.Customer.Email, "Your order was successfully placed.", ".");
            client.Send(message);

        }
    }

    public class DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public void SaveChanges()
        {
            // TODO: Implement this method

        }
    }

    public class DbSet<T>
    {
        public void Add(Order order)
        {
            // TODO: Implement this method

        }
    }
    public class Order
    {
        public Customer Customer { get; set; }
    }

    public class Customer
    {
        public string Email { get; set; }
    }
}
