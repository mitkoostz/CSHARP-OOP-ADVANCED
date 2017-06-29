using System;

namespace Ferrari
{
    public class Startup
    {
    
      public interface ICar
        {
            string driverName { get; }
            string model { get; }
            void Gas();
            void Brakes();
        }

        public class Ferrari : ICar
        {

            public Ferrari(string driverName,string model)
            {
                this.driverName = driverName;
                this.model = model;
            }
            public void Brakes()
            {
                Console.Write("Brakes!");
            }
            public void Gas()
            {
                Console.Write("Zadu6avam sA!");
            }

            public string driverName { get; set; }
            public string model { get; set; }


        }

        public static void Main()
        {
            string driverName = Console.ReadLine();
            

            ICar car = new Ferrari(driverName,"488-Spider");

            Console.Write($"{car.model}/");
            car.Brakes();
            Console.Write("/");
            car.Gas();
            Console.Write("/" + car.driverName);
            Console.WriteLine();

            string ferrariName = typeof(Ferrari).Name;

            string iCarInterfaceName = typeof(ICar).Name;





        }

    }
}
