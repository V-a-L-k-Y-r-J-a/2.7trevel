using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trevel
{
    internal class Helper 

    {
        public static trevelContext db = new trevelContext();
        public static User userSession;
        internal static Task? task;


    }
}
