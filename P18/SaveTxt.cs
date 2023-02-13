using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P18
{
    class SaveTxt : ISave
    {
        private string name;

        public SaveTxt(string Name)
        {
            name = Name;
        }

        public void SaveText(IEnumerable<IAnimal> animals)
        {
            using (StreamWriter streamWriter = new StreamWriter("Animals.txt", true))
            {
                string note = string.Empty;
                foreach (var i in animals)
                {
                    note = $"{i.Class}/{i.Genus}";
                    streamWriter.WriteLine(note);
                }
            }
        }
    }
}
