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
            //newAnimal.Move();
            //newAnimal.MakeNoise();
            newAnimal.Age = 5;

            //Console.ReadLine();

            Dog Sami = new Dog();
            Sami.Age = 13;
            Sami.NumOfLegs = 4;
            

            //Console.ReadLine();


            Dog Rufus = new Dog();
            Rufus.Age = 5;
            //Rufus.Move();
            //Rufus.MakeNoise();

            //Console.ReadLine();

            Console.WriteLine(DateTime.Now);

            Console.ReadLine();

            SoloLearn sl = new SoloLearn();

            SoloLearn s2 = new SoloLearn();

            sl.TimesTwo(36);

            Console.ReadLine();

            Console.WriteLine("The sum of the parameters is " + s2.Sum(34, 43));

            Console.ReadLine();


            Console.WriteLine(Pow(3, 4));

            Console.WriteLine(Pow(6));

            

        }


        static int Pow(int x, int y = 2)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }


    }


}
