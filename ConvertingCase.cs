using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    internal class ConvertingCase
    {
        public static List<string> toConvert(List<string> list) { 
            List<string> result = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(list[i].ToLower());
            }
            return result;
        }
    }
}
