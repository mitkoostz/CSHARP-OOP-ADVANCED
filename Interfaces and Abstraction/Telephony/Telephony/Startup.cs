using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
    public class Smartphone : ICallable,IBrowsable
    {
        public Smartphone(List<string> numbers , List<string> sites)
        {
            this.numbers = numbers;
            this.sites = sites;
        }

        public List<string> numbers { get; set; } = new List<string>();
        public List<string> sites { get; set; } = new List<string>();

    }


    public interface ICallable
    {
        List<string> numbers { get; set; }
    }
    public interface IBrowsable
    {
        List<string> sites { get; set; }

    }

    public class Startup
    {
        public static void Main()
        {
            List<string> numbers = Console.ReadLine().Split(' ').ToList();
            List<string> sites = Console.ReadLine().Split(' ').ToList();

            Smartphone phone = new Smartphone(numbers,sites);

            foreach (var number in numbers)
            {
                Console.WriteLine("Calling... " + number);
            }

            foreach (var site in sites)
            {
                if (site.Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid URL!");

                }else
                    Console.WriteLine("Browsing: " + site + "!");


            }



        }
    }
}
