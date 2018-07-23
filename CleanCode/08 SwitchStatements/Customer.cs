
namespace CleanCode.SwitchStatements
{
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


// APPLY STRATEGY PATTENR
// JUGAR OPEN CLOSED y LISKOV SUBSTITUTION

