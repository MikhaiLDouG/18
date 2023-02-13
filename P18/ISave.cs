using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18
{
    interface ISave
    {
        void SaveText(IEnumerable<IAnimal> animals);
    }
}
