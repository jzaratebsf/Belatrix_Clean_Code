﻿
namespace CleanCode.SwitchStatements
{
    //public class Customer
    //{
    //    public CustomerType BillType { get; set; }
    //}

    //public enum CustomerType
    //{
    //    PayAsYouGo = 1,
    //    Unlimited
    //}


    public class Customer
    {
        public int CustomerId { get; set; }
    }


    public class CustomerPaysAsYouGo : Customer
    {
        
    }

    public class CustomerUnlimited : Customer
    {
        
    }

}
