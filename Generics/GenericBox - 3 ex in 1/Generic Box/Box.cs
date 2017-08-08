using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Box
{
    public class Box<T>
    {
        private List<T> box;
        T lastAdd;
        public Box()
        {
            box = new List<T>();
         }

        public void Add(T item)
        {
            box.Add(item);
            lastAdd = item;
         }
        Type Type = typeof(T);

        public override string ToString()
        {
           
            return Type.FullName + ": " + string.Join(" ", box);
        }
        
       


    }

    }

