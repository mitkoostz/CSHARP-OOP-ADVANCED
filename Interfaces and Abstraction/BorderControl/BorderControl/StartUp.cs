using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{

    public interface IIdentifiable
    {
       string id { get; }
       
    }
    public abstract class Inhabitant : IIdentifiable
    {
        public string id { get; set; }
    }
    public class Robot : Inhabitant
    {
        public Robot(string model,string id)
        {
            this.model = model;
            this.id = id;
        }

        public string model { get; set; }

        
        
    }
    public class Citizen : Inhabitant
    {
        public Citizen(string name , int age, string id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
                
        }
        public string name { get; set; }
        public int age { get; set; }
        
    }


    public class StartUp
    {
        public static void Main()
        {

            List<Inhabitant> inhabitant = new List<Inhabitant>();

            ReadAndSaveData(inhabitant);

            List<Inhabitant> invalidIds = new List<Inhabitant>();

            invalidIds = CheckId(inhabitant);
        }

        private static List<Inhabitant> CheckId(List<Inhabitant> iidentifiable)
        {
            string verifyId = Console.ReadLine();

            iidentifiable = iidentifiable.Where(x => x.id.EndsWith(verifyId)).ToList();

            foreach (var inhabitant in iidentifiable)
            {
                Console.WriteLine(inhabitant.id);
            }

            return iidentifiable;
        }

        private static void ReadAndSaveData(List<Inhabitant> iidentifiable)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputParams = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputParams.Length == 3)
                {
                   Inhabitant current = new Citizen(inputParams[0], int.Parse(inputParams[1]), inputParams[2]);
                    iidentifiable.Add(current);
                }
                else
                {
                    Inhabitant current = new Robot(inputParams[0], inputParams[1]);
                    iidentifiable.Add(current);
                }


                input = Console.ReadLine();
            }
        }
    }
}
