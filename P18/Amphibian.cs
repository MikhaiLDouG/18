using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18
{
    class Amphibian : IAnimal
    {
        public string Class { get { return _class; } }

        public string Genus { get { return _genus; } }

        private string _class;

        private string _genus;
        public Amphibian(string Genus)
        {
            _genus = Genus;
            _class = "Amphibian";
        }
    }
}
