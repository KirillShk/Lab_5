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
            int sum2 = 0; // сумма второй диагонали
            bool f1 = false; // флажок по строкам
            bool f2 = false; // флажок по столбцам
            bool f3 = false; // флажок по диагоналям
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int[] sum_arrray = new int[n];
            #region действия над строками
            for (int i=0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        sum += array[i, j];
                    }
                   // Console.WriteLine("Сумма {0}-й строки = {1}", i, sum);
                    sum_arrray[i] = sum;
                    sum = 0;
                }
            for (int i = 0; i < n-1; i++)
            {
                if (sum_arrray[i] == sum_arrray[i+1])
                {
                    f1 = true;
                }
            }
                //Console.WriteLine(f1);
            #endregion
            #region действие над столбцами
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    sum += array[i, j];
                }
                //Console.WriteLine("Сумма {0}-го столбца = {1}", j, sum);
                sum_arrray[j] = sum;
                sum = 0;
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (sum_arrray[i] == sum_arrray[i + 1])
                {
                    f2 = true;
                }
            }
              // Console.WriteLine(f2);
            #endregion
            #region действие над диагоналями
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        sum += array[i, j];      
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == n - 1)
                        sum2 += array[i, j];
                }
            }
            f3 = (sum == sum2);
                // Console.WriteLine(f3);
            #endregion
            if (f1 == f2 && f2 == f3)
                Console.WriteLine("Массив является магическим квадратом");
            else
                Console.WriteLine("Массив не является магическим квадратом");
            Console.ReadKey();
        }
    }
}
