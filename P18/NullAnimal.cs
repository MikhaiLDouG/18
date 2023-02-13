using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18
{
    class NullAnimal : IAnimal
    {
        public string Class { get { return _class; } }

        public string Genus { get { return _genus; } }

        private string _class;

        private string _genus;

        public NullAnimal()
        {
            _genus = "Not determined";
            _class = "Not determined";
        }
    }
}
