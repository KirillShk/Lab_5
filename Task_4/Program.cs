using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rnd = new Random();
            int kol = 0;
            for (int i = 0; i < 20; i++)
            {
                array[i] = rnd.Next(-50,50);
                Console.Write("{0} ",array[i]);
            }
            for (int i=1; i < 20; i+=2)
            {
                    if ((array[i] > 0) && ((array[i]%2) !=0))
                        kol++;

            }
            Console.WriteLine();
            Console.WriteLine("Количество нечетных элементов больше нуля, стоящих на четных местах массива = {0}",kol);
            Console.ReadKey();
        }

    }
}
