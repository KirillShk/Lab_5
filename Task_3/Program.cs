using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(-50,50);
                Console.Write("{0} ", array[i]);
            }
            #region Сортировка первых 5-ти элементов массива
            for (int i=0; i<5; i++)
            {
                for (int j=i+1; j<5; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i]= array[j];
                        array[j]= t;
                    }    
                }
            }
            #endregion
            #region Сортировка второй части массива
            for (int i = 5; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            #endregion
            Console.WriteLine();
            Console.WriteLine("Массив c 1 по 5 элементы");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Массив c 5 по 10 элемент");
            for (int i = 5; i < 10; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}