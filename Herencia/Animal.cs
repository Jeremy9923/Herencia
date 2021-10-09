using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Animal
    {
        public string animalSpecies { get; set; }

        public int animalLegs { get; set; }

        public Boolean animalEat { get; set; }



        public string getInfo()
        {
            var eat = "";
            if (animalEat == true)
            {
                eat = " el animal come ";
            }
            else
            {
                eat = "el animal no come";
            }
            return " El animal es " + animalSpecies + " y tiene " + animalLegs + " piernas y come "  + eat;
        }

    

        public string food(string comida, string especie)
        {
            return " El" + especie + " esta comiendo " + comida;
        }

        public virtual string comer()
        {
            return " el animal esta comiendo";
        }
    }
}
