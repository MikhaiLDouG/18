using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace P18
{
    public partial class MainWindow : Window , IView
    {
        Repository repository;
        public MainWindow()
        {
            InitializeComponent();
            repository = new Repository(this);
            ListAnimal.ItemsSource = repository.animals;

            button1.Click += (s, e) => repository.Add();
            buttonSavekJson.Click += (s, e) => repository.SaveJson();
            buttonSaveTxt.Click += (s, e) => repository.SaveTxt();
            buttonDel.Click += (s, e) => repository.Del((IAnimal)ListAnimal.SelectedItem);
        }

        public string ClassAnimal { get => ClassTxt.Text; }
        public string GenusAnimal { get => GenusTxt.Text; }
        public ObservableCollection<IAnimal> animalsList { set => ListAnimal.ItemsSource = value; }
    }
}
