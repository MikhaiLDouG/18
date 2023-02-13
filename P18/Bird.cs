using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18
{
    class Bird : IAnimal
    {
        public string Class { get { return _class; } }

        public string Genus { get { return _genus; } }

        private string _class;

        private string _genus;

        public Bird(string Genus)
        {
            _genus = Genus;
            _class = "Bird";
        }
    }
}
