using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Count_Method_Strings
{
    public static class Box 
    {

        public static int Compare<T>(List<T> list , T element)
            where T : IComparable
        {
            int counter = 0;

            foreach (var item in list)
            {
                if(item.CompareTo(element) > 0)
                {
                    counter++;
                }
            }
            return counter;

        }
    }
}
