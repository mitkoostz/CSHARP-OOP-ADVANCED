using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Swap_Method_Strings
{
    public class startup
    {
        public static void Main()
        {
            List<int> myC = new List<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                myC.Add(input);

            }
            Type Tinfo = typeof(int);

            
            var indexsForSwap = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            Swapper.Swap(myC, indexsForSwap[0], indexsForSwap[1]);


            foreach (var str in myC)
            {
                Console.WriteLine(Tinfo.FullName + ": " + str);
            }

        }
    }
}
