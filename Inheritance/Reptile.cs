using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() 
        {
            IsItAlive = true;
            Legs = 4;
            Habitat = "Desert";
            Age = 3;
        }

        public bool ColdBlooded { get; set; }
        public bool Scaley { get; set; }

        public string Continent { get; set; }
        public bool Regenerate { get; set; }

    }
}
