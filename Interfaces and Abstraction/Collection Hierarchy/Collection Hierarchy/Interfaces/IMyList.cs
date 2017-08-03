using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Hierarchy.Interfaces
{
    public interface IMyList : IAddable,IRemoveable
    {
        int count { get; }

    }
}
