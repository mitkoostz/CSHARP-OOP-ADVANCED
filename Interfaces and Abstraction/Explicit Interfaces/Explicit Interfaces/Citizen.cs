using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Interfaces
{
    using Interfaces;
    public class Citizen : IPerson, IResident
    {
        public Citizen(string name , string country, string age)
        {
            this.name = name;
            this.country = country;
            this.age = age;
        }

         string IResident.GetName()
        {
            return "Mr/Ms/Mrs";
        }
        


        public string age { get; set; }

        public string country { get; set; }
       
        public string name { get; set; }
        



        public string GetName()
        {
            return this.name;
        }
        
        

        
        
    }
}
