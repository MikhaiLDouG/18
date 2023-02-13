using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace P18
{
    interface IView
    {
        string ClassAnimal { get; }
        string GenusAnimal { get; }

        ObservableCollection<IAnimal> animalsList { set; }
    }
}
