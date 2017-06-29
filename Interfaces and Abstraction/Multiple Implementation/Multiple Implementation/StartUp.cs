using System;
using System.Reflection;

namespace MultipleImplementation
{
    public class StartUp
    {
        public class Citizen : IPerson , IIdentifiable , IBirthable
        {
            public Citizen(string name, int age,string id , string birthday)
            {
                this.Name = name;
                this.Age = age;
                this.id = id;
                this.birthday = birthday;
            }

            public string Name { get; set; }

            public int Age { get; set; }

            public string id { get; set; }

            public string birthday { get; set; }

        }
        public interface IPerson
        {
            string Name { get; }

            int Age { get; }
        }
        public interface IIdentifiable
        {
            string id { get; }
            
        }
        public interface IBirthable
        {
            string birthday { get; }
        }

        public static void Main()
        {
            Type identifiableInterface = typeof(Citizen).GetInterface("IIdentifiable");

            Type birthableInterface = typeof(Citizen).GetInterface("IBirthable");

            PropertyInfo[] properties = identifiableInterface.GetProperties();

            Console.WriteLine(properties.Length);

            Console.WriteLine(properties[0].PropertyType.Name);

            properties = birthableInterface.GetProperties();

            Console.WriteLine(properties.Length);

            Console.WriteLine(properties[0].PropertyType.Name);

            string name = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());

            string id = Console.ReadLine();

            string birthdate = Console.ReadLine();

        }
    }
}
