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

            newAnimal.Age = 5;
            Console.WriteLine(newAnimal.Age);






            int a = 3;
            Sqr(ref a);
            Console.ReadLine();




            int q, r;
            GetValues(out q, out r);
            Console.WriteLine(q + " " + r);

            string nm;
            Ask(out nm);

            double myDouble = 3.323;
            Print(myDouble);
        }


        static void Sqr(ref int x)
        {
            x = x * x;
            Console.WriteLine(x);
        }                               //ref keyword


        static void swapVarValuesWithRef(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }


        static void GetValues(out int x, out int y)
        {
            x = 5;
            y = 42;
        }



        static void Ask(out string name)
        {
            name = Console.ReadLine();
        }



        static void Print(int a)
        {
            Console.WriteLine("Value: " + a);
        }



        static void Print(double a)
        {
            Console.WriteLine("Value: " + a);
        }
    }


}
