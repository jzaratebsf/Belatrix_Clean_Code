
namespace CleanCode.MagicNumbers
{
    public class MagicNumbers
    {
        enum Status { Approve = 1, Denied = 2 };
        public void ApproveDocument()
        {

            if ((int)Status.Approve == 1)
            {
                // ...
            }
            else
            if ((int)Status.Denied == 2)
            {
                // ...
            }
        }

     
        public void RejectDoument(RejectedState Status)
        {
            switch (Status)
            {
                case Status.RejectedOK:
                    // ...
                    break;
                case Status.Rejectedfail:
                    // ...
                    break;
            }
        }

        public class RejectedState
        {
            public string RejectedOK { get; set; }
            public string Rejectedfail { get; set; }
        }
    }
}
}
