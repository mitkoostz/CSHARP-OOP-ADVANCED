using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Explicit_Interfaces;
using Explicit_Interfaces.Interfaces;

namespace Explicit_Interfaces
{
    public class startup
    {
        
        public static void Main()
        {
            List<Citizen> citizens = new List<Citizen>();
            
            string input = Console.ReadLine();
            while (input != "End")
            {
                var inputParams = input.Split(' ');
                var name = inputParams[0];
                var country = inputParams[1];
                var age = inputParams[2];

                Citizen current = new Citizen(name,country,age);
                citizens.Add(current);

                input = Console.ReadLine();
            }

            foreach (var citizen in citizens)
            {
                Console.WriteLine(citizen.name);

                IResident ir = (IResident)citizen;

                Console.WriteLine(ir.GetName() + " " + citizen.name);
            }


           //IControl c = (IControl)obj;
           // c.Paint();  // Calls IControl.Paint on SampleClass.

        }
    }
}
