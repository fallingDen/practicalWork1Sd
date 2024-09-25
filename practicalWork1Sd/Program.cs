using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalWork1Sd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int M = 0;

            Console.WriteLine("Практическая работа №1.");
            Console.WriteLine("Соколов Даниил ИСП-41.");
            Console.WriteLine();

            while (true)
             {
                Console.WriteLine("Введите количество строк матрицы N:");
                Console.WriteLine();
                Console.Write("N = ");
                if(int.TryParse(Console.ReadLine(), out N) && N>0)
                break;
                Console.WriteLine("Error404!");
                Console.WriteLine("Введите положительное число.");
             }

             Console.WriteLine();

             while (true)
             {
                Console.WriteLine("Введите количество столбцов матрицы M:");
                Console.WriteLine();
                Console.Write("M = ");
                if (int.TryParse(Console.ReadLine(), out M) && M > 0)
                    break;
                Console.WriteLine("Error404!");
                Console.WriteLine("Введите положительное число.");
             }

             Console.WriteLine();
            Console.WriteLine("Создание матрицы.");
            Console.WriteLine();

            double[,] matr = new double[N,M];
 
            int counter = 0;

            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < M; j++)
                {
                   
                  matr[i, j] = Math.Sin(i + j / 3);
                    if (matr[i, j] > 0) { counter++; }

                    if (matr[i, j] < 0) Console.Write($"{Math.Round(matr[i, j], 2):F3} |");
                    else Console.Write($" {Math.Round(matr[i, j], 2):F3} |");
                }
                
                Console.WriteLine();
                Console.WriteLine();
            }

       
            Console.WriteLine();
            Console.WriteLine("Выявление количества положительных элементов.");
            Console.WriteLine();
           

            Console.WriteLine("количество положительных элементов = " + counter);





            Console.ReadKey();

           
        }
    }
}
