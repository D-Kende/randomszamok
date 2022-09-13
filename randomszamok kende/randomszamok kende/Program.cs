using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomszamok
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] tomb = new int[40];
            int poz = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(-100, 101);
                Console.Write(tomb[i]);
                Console.Write(" ");
                if (tomb[i] > 0)
                {
                    poz++;
                }

            }
            Console.WriteLine();
            Console.WriteLine("Pozitív számok: " + poz + " db");



            Console.ReadKey();




        }
    }
}
