using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace P18
{
    class SaveJson : ISave
    {
        private string name;

        public SaveJson(string Name)
        {
            name = $"{Name}.json";
        }

        public void SaveText(IEnumerable<IAnimal> animals)
        {
            File.WriteAllText(name, JsonConvert.SerializeObject(animals));
        }
    }
}
