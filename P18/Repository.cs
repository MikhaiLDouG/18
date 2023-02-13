using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18
{
     class Repository
    {
        private IView view;
        private IModel model;

        public ObservableCollection<IAnimal> animals;
        public Repository(IView view)
        {
            this.view = view;
            model = new Model();
            animals = new ObservableCollection<IAnimal>();
            animals = model.Animals;
        }

        public void Add()
        {
            model.AddAnimal(view.ClassAnimal, view.GenusAnimal);
        }

        public void Del(IAnimal animal)
        {
            model.Del(animal);
        }

        public void SaveJson()
        {
            SaveJson j = new SaveJson("Animals");
            model.Save(j);
        }
        public void SaveTxt()
        {
            SaveTxt t = new SaveTxt("Animals");
            model.Save(t);
        }
    }
}
