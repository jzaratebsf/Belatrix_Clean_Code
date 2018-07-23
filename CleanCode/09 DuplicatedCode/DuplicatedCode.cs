
using System;

namespace CleanCode.DuplicatedCode
{
    class DuplicatedCode
    {

        internal class GuestAdmissionTime
        {
            public string name  {get; set; }
            public string admissionDateTime { get; set; }
        }

        
        public void AdmitGuest(GuestAdmissionTime guestime)
        {
            GetAddmissionTime(guestime);
        }

        public void UpdateAdmission(int admissionId, GuestAdmissionTime guestime)
        {
            GetAddmissionTime(guestime);
        }

        private void GetAddmissionTime(GuestAdmissionTime Time)
        {
            // Some logic 
            // ...

            int time;
            int hours = 0;
            int minutes = 0;
            if (!string.IsNullOrWhiteSpace(Time.admissionDateTime))
            {
                if (int.TryParse(Time.admissionDateTime.Replace(":", ""), out time))
                {
                    hours = time / 100;
                    minutes = time % 100;
                }
                else
                {
                    throw new ArgumentException("admissionDateTime");
                }

            }
            else
                throw new ArgumentNullException("admissionDateTime");

            // Some more logic 
            // ...
            if (hours < 10)
            {

            }
        }
    }
}
