using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Count_Method_Strings
{
    public class startup
    {
        public static void Main()
        {
            List<double> list = new List<double>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var text = double.Parse(Console.ReadLine());
                list.Add(text);
            }

            var lastInput = double.Parse(Console.ReadLine());
            

            Console.WriteLine(Box.Compare(list, lastInput));
        }
    }
}
