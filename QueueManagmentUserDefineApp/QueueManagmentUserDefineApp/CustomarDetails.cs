using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueManagmentUserDefineApp
{
    class CustomarDetails
    {
        public static Queue<string> CustomarNameQueue=new Queue<string>();
        public static Queue<string> CustomarComplainQueue=new Queue<string>();
        public  static Queue<int> CustomerSerialNumberQueue=new Queue<int>();
        public static int SerialNumber = 1;
    }
}
