using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collection_Hierarchy.Collection;

namespace Collection_Hierarchy
{
    class startup
    {
        public static void Main()
        {
            string[] elementsToAdd = Console.ReadLine().Split();
            int countOfRemoveOps = int.Parse(Console.ReadLine());

            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            printIndexs(elementsToAdd, addCollection, addRemoveCollection, myList);
            Console.WriteLine();
            for (int i = 0; i < countOfRemoveOps; i++)
            {
                Console.Write(addRemoveCollection.Remove() + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < countOfRemoveOps; i++)
            {
                Console.Write(myList.Remove() + " ");
            }
            Console.WriteLine();

        }

        private static void printIndexs(string[] elementsToAdd, AddCollection addCollection, AddRemoveCollection addRemoveCollection, MyList myList)
        {
            foreach (var element in elementsToAdd)
            {
                Console.Write(addCollection.Add(element) + " ");
            }
            Console.WriteLine();

            foreach (var element in elementsToAdd)
            {
                Console.Write(addRemoveCollection.Add(element) + " ");
            }
            Console.WriteLine();

            foreach (var element in elementsToAdd)
            {
                Console.Write(myList.Add(element) + " ");
            }
        }
    }
}
