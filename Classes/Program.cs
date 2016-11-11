using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            //Class is the blueprint for a house, e.g. 
            //The House itself is constructed from that blueprint

            //INSTANCE of a class is your OBJECT

            Animal newAnimal = new Animal();
            newAnimal.Move();
            newAnimal.MakeNoise();
        }
    }


}
