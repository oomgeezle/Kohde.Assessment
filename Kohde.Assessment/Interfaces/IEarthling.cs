using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohde.Assessment.Interfaces
{
    public interface IEarthling
    {
        string Name { get; set; }
        int Age { get; set; }

        string GetDetails();
    }
}
