using System;

namespace SOLID._04_Interface_Segregation
{
    public interface IPrintTasks
    {
        bool PrintDuplexContent(string content);
        bool FaxContent(string content);
    }

    public class IPrintask02
    {
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done"); return true;
        }
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done"); return true;
        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done"); return true;
        }

    }

    public class HPLaserJet : IPrintask02, IPrintTasks
    {

        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax Done"); return true;
        }        
        
        public bool PrintDuplexContent(string content)
        {
            Console.WriteLine("Print Duplex Done"); return true;
        }        
    }

    public class CannonMG2470 : IPrintask02,IPrintTasks
    {
        public bool PrintDuplexContent(string content)
        {
            return false;
        }
        public bool FaxContent(string content)
        {
            return false;
        }
    }
}
