using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class dog: Animal
    {

        public string specie { get; set; }

        public string species()
        {
            return " es de esa especie....";
        }
        public override string comer()
        {
            return " no esta  comiendo .....";
        }
    }
}
