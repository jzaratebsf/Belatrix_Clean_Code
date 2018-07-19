
using System.Text;

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
            if ((int)Status.Denied == 2)
            {
                // ...
            }
        }

        public class RejectedState
        {
            public string RejectedOK { get; set; }
            public string Rejectedfail { get; set; }
        }

        StringBuilder estado = new StringBuilder("1", "2");

        public void RejectDoument(StringBuilder estado)
        {
            switch (estado)
            {
                case "1":  
                    // ...
                    break;
                case "2":
                    // ...
                    break;
            }
        }

        
    }
}

