using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public static class StringUnits
    {
        public static string ReverseName(string name)
        {
            char[] arr = name.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

    }
}
