using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace P18
{
    class Model : IModel
    {
        public ObservableCollection<IAnimal> Animals { get => animals; }

        private ObservableCollection<IAnimal> animals;

        public Model()
        {
            animals = new ObservableCollection<IAnimal>();
        }

        public void AddAnimal(string ClassAnimal,string GenusAnimal)
        {
            animals.Add(AnimalFactory.GetAnimal(ClassAnimal, GenusAnimal));
        }

        public void Del(IAnimal animal)
        {
            animals.Remove(animal);
        }

        public void Save(ISave save)
        {
            save.SaveText(animals);
        }
    }
}
