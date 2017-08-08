using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Swap_Method_Strings
{
    public static class Swapper
    {


        public static List<T> Swap<T>(List<T> list, int index1, int index2)
        {
            var first = list[index1];
            list[index1] = list[index2];
            list[index2] = first;

            return list;

        }

    }
}
