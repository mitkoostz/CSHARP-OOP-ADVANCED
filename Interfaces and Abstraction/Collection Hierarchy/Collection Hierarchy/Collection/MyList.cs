using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Hierarchy.Collection
{
    using Interfaces;
    public class MyList : Collection, IMyList
    {
        
        public int count
        {
            get
            {
                return base.Elements.Count;
            }
        }

        /// <summary>
        /// Add method which insert item on first index
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public int Add(string element)
        {
            base.Elements.Insert(0, element);
            return 0;
        }

        /// <summary>
        /// Remove method which remove item on first index
        /// </summary>
        /// <returns></returns>
        public string Remove()
        {
            string element = base.Elements[0];
            base.Elements.RemoveAt(0);
            return element;
        }
    }
}
