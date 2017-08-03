using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Hierarchy.Collection
{
    public abstract class Collection
    {
        private List<string> elements;

        public Collection()
        {
            this.elements = new List<string>();
        }

        public List<string> Elements
        {
            get
            {
                return elements;
            }

            set
            {
                elements = value;
            }
        }
    }
}
