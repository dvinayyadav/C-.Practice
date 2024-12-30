using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    class CheckingPresentOrNot
    {
       public static Boolean isPresent(List<string> list, string newfru)
        {
            string str = newfru.ToLower();
           List<string> list2 = new List<string>();
            if (list2.Contains(str.ToLower())){
                return true;
            }
            return false;
        }
    }
}
