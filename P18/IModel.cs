using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18
{
    interface IModel
    {
        ObservableCollection<IAnimal> Animals { get;}

        void AddAnimal(string ClassAnimal, string GenusAnimal);
        void Del(IAnimal animal);
        void Save(ISave save);
    }
}
