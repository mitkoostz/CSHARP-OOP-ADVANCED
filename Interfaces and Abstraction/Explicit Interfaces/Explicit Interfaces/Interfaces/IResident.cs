using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Interfaces.Interfaces
{
    public interface IResident
    {
        string name { get; }

        string country { get; }

        string GetName();
    }
}
