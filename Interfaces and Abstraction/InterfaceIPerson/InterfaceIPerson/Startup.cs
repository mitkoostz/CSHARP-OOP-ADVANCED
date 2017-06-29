using System;
using System.Reflection;

namespace InterfaceIPerson
{
    public class Startup
    {
        private static object quot;

        public class Citizen : IPerson
        {
            public Citizen(string name , int age)
            {
                this.Name = name;
                this.Age = age;
                    
            }

         public string Name { get; set; }
         public int Age { get; set; }

        }
        public interface IPerson
        {
            string Name { get; }

            int Age { get; }

        }

        public static void Main()
        {
            Type personInterface = typeof(Citizen).GetInterface("IPerson");

            PropertyInfo[] properties = personInterface.GetProperties();

            Console.WriteLine(properties.Length);

            string name = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());

            IPerson person = new Citizen(name, age);

            Console.WriteLine(person.Name);

            Console.WriteLine(person.Age);

        }
    }
}
