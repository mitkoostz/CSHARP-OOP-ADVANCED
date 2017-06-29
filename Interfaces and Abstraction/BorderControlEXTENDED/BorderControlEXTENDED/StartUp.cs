using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{

    public interface IIdentifiable 
    {
        string id { get; }

    }
    public interface IBirthable 
    {
        DateTime birthday { get; }
    }
    public class Robot : IIdentifiable
    {
        public Robot(string model, string id)
        {
            this.model = model;
            this.id = id;
        }

        public string model { get; set; }
        public string id { get; set; }



    }
    public class Citizen : IIdentifiable,IBirthable
    {
        public Citizen(string name, int age, string id,DateTime birthday)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.birthday = birthday;
        }
        public string name { get; set; }
        public int age { get; set; }
        public string id { get; set; }
        public DateTime birthday { get; set; } 
    }
    public class Pet : IBirthable
    {
        public Pet (string name, DateTime birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }
        public string name { get; set; }
        public DateTime birthday { get; set; } 
    }


    public class StartUp
    {
        public static object Culture { get; private set; }

        public static void Main()
        {

            List<IBirthable> birthable = new List<IBirthable>();
            List<IIdentifiable> identifiable = new List<IIdentifiable>();

            ReadAndSaveData(birthable,identifiable);

            int yearForSearch = int.Parse(Console.ReadLine());

            List<IBirthable> birthdayEqual = new List<IBirthable>();

            birthdayEqual = birthable.Where(x => x.birthday.Year == yearForSearch).ToList();

            if(birthdayEqual.Count != 0)
            {
                foreach (var birthday in birthdayEqual)
                {
                    Console.WriteLine(birthday.birthday.ToString("dd/MM/yyyy"));
                }
            }
           

        }

        private static void ReadAndSaveData(List<IBirthable> birthable,List<IIdentifiable> identifiable)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputParams = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

               

                switch (inputParams[0])
                {
                    case "Robot":
                        IIdentifiable currentRobot = new Robot(inputParams[1], inputParams[2]);
                        identifiable.Add(currentRobot);
                        break;

                    case "Citizen":
                        DateTime dt = DateTime.ParseExact(inputParams[4],"dd/MM/yyyy",CultureInfo.InvariantCulture);
                        IBirthable currentCitizen = new Citizen(inputParams[1]
                            , int.Parse(inputParams[2]), inputParams[3],dt);                       
                        birthable.Add(currentCitizen);
                        break;

                    case "Pet":
                        DateTime dtt = DateTime.ParseExact(inputParams[2], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        IBirthable currentPet = new Pet(inputParams[1],dtt);
                        birthable.Add(currentPet);
                        break;

                }



                input = Console.ReadLine();
            }
        }
    }
}
