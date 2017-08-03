using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Interfaces.Interfaces
{
    public interface IPerson
    {
        string name { get; }

        string age { get; }

        string GetName();
    }
}
