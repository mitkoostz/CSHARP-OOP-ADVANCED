
using System;
using System.Linq;

namespace Generic_Box
{
   public class startup
    {
        public static void Main()
        {
           

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
               var input =  Console.ReadLine().Split().Select(x => int.Parse(x));

               Box<int> texts = new Box<int>();

                foreach (var item in input)
                {
                    texts.Add(item);
                    
                }

                Console.WriteLine( texts.ToString());
            }

        }
    }
}
