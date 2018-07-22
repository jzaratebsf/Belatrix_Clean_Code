using System;

namespace CleanCode.SwitchStatements
{
    public class MonthlyPayment
    {
        public float CallCost { get; set; }
        public float SmsCost { get; set; }
        public float TotalCost { get; set; }

        MonthlyUsagePaysAsYouGo UsagePaysAsYouGo = new MonthlyUsagePaysAsYouGo();
        MonthlyUsageUnlimited UsageUnlimited = new MonthlyUsageUnlimited();

        //public void Generate(MonthlyUsage usage)
        //{
        //    switch (usage.Customer.Type)
        //    {
        //        case CustomerType.PayAsYouGo:
        //            CallCost = 0.12f * usage.CallMinutes;
        //            SmsCost = 0.12f * usage.SmsCount;
        //            TotalCost = CallCost + SmsCost;
        //            break;

        //        case CustomerType.Unlimited:
        //            TotalCost = 54.90f;
        //            break;

        //        default:
        //            throw new NotSupportedException("The current customer type is not supported");
        //    }
        //}
        
        private void GenerateBillCustomerPayAsYouGo(MonthlyUsagePaysAsYouGo UsagePaysAsYouGo)
        {
                CallCost = 0.12f * UsagePaysAsYouGo.CallMinutes;
                SmsCost = 0.12f * UsagePaysAsYouGo.SmsCount;
                TotalCost = CallCost + SmsCost;                                           
        }

        private void GenerateBillCustomerUnlimited(MonthlyUsageUnlimited UsageUnlimited)
        {
                TotalCost = 54.90f;            
        }
    }
}