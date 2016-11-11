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

            Animal newAnimal = new Animal();
            newAnimal.Move();
            newAnimal.MakeNoise();
            newAnimal.Age = 5;

            Console.ReadLine();

            Dog Sami = new Dog();
            Sami.Age = 13;
            Sami.NumOfLegs = 4;
            

            Console.ReadLine();


            Dog Rufus = new Dog();
            Rufus.Age = 5;
            Rufus.Move();
            Rufus.MakeNoise();


            
        }


       
    }


}
