using System;

namespace SOLID._01_SingleResponsability
{
    public class Addition
    {
        private int resultSum;
        private string rangemessage;

        public void SumTwoParameters(int firstinteger, int secondinteger)
        {
            resultSum = firstinteger + secondinteger;
            evaluateSum();
            writeResult();
        }

        private void evaluateSum()
        {
            if (resultSum > 0 && resultSum <= 10) rangemessage = "Value between 0 and 10";
            else if (resultSum > 10 && resultSum <= 20) rangemessage = "Value between 11 and 20";
            else if (resultSum > 20 && resultSum <= 30) rangemessage = "Value between 11 and 20";
        }

        private void writeResult()
        {
            Console.WriteLine(string.Format("The sum is: {0} and is in range {1}", resultSum, rangemessage));
        }
    }
}
