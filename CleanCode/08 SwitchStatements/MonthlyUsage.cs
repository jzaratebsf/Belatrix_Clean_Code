namespace CleanCode.SwitchStatements
{
    public class MonthlyUsage
    {
        public int CallMinutes { get; set; }
        public int SmsCount { get; set; }        
    }

    public class MonthlyUsagePaysAsYouGo : MonthlyUsage
    {
        public CustomerPaysAsYouGo CustomerPaysAsYouGo { get; set; }
    }

    public class MonthlyUsageUnlimited : MonthlyUsage
    {
        public CustomerUnlimited CustomerUnlimited { get; set; }
    }



}