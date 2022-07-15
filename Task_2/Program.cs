using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                array[i] = rnd.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            int min = array[1];
            foreach (int a in array)
            {
                if (a > max)
                    max = a;
                else if (a < min)
                    min = a;
            }
            Console.WriteLine();
            Console.Write("Min = {0}, Max = {1}", min, max);
            Console.WriteLine();
            Console.WriteLine("Среднеарифмитическое между Min и Max = {0}", (max + min) / 2);
            Console.ReadKey();

        }
    }
}
