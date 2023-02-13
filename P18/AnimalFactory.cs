using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18
{
    static class AnimalFactory
    {
        public static IAnimal GetAnimal(string Class, string Genus)
        {
            switch (Class)
            {
                case "Mammals": return new Mammals(Genus);
                case "Bird": return new Bird(Genus);
                case "Amphibian": return new Amphibian(Genus);

                default: return new NullAnimal();
            }
        }
    }
}
