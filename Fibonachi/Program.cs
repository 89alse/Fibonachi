using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj clanova niza:");

            int br = int.Parse(Console.ReadLine());

            int cl = 0;
            Console.WriteLine(cl);

            int cl1 = 1;
            Console.WriteLine(cl1);

          //  cl1 = cl + cl1;
            

            int cl2 = 2;
            Console.WriteLine(cl2);
            
            
            for (int i = 1; i < br-2; i++)
            {


                 cl = cl1;
                 cl1 = cl2;
                 cl2 = cl2 + cl;
                

                Console.WriteLine(cl2);
            }

            Console.ReadKey();




        }
    }
}
