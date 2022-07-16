using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            int sum = 0;
            bool f = false;
            // массив для значений сумм строк, столбцов, диагоналей
            /*int  x = 2 * n + 2;
            int[] array_chan = new int[x];*/
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            /*  for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < n; j++)
                 {
                    Console.Write("{0} ", array[i, j]);
                 }
                 Console.WriteLine();
             }*/
            int[] sum_arrray = new int[n];
            for (int i=0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        sum += array[i, j];
                    }
                    Console.WriteLine("Сумма {0}-й строки = {1}", i, sum);
                    sum_arrray[i] = sum;
                    sum = 0;
                }
            foreach (int a in sum_arrray)
            {
                if (a == a + 1)
                {
                    f = true;
                    break;
                }
            }
            if (!f)
                Console.WriteLine("Элементы совпали");
            Console.ReadKey();
           
        }
    }
}
