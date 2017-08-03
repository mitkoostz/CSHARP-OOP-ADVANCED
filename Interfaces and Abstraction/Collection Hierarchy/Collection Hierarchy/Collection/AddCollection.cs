using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Hierarchy.Collection
{
    using Interfaces;
    public class AddCollection : Collection, IAddable
    {


        /// <summary>
        ///  Add method which insert item on last index
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public int Add(string element)
        {
            
            base.Elements.Add(element);
            return Elements.Count - 1;
        }
    }
}
