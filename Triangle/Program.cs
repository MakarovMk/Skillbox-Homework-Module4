using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        public const int cell = 4; //4 - ширина условной ячейки для хранения значения
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк тругольника (не более 25) и нажмите Enter: ");
            int row = Convert.ToInt32(Console.ReadLine());
            int[,] triangle = new int[row, row];

            for (int i = 0; i < row; i++) //заполнение внешних рядов треугольника единицами
            {
                triangle[i, 0] = 1;
                triangle[i, i] = 1;
            }

            for (int i = 2; i < row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j]; //заполнение "ячейки" с суммой значений
                }
            }

            //Console.SetBufferSize(203, 160); //установка буфера и 
            //Console.SetWindowSize(203, 32);  //размера окна для корректного отображения максимального (25) кол-ва строк

            int column = cell * row; //определение места вывода верхней единицы

            if (row >= 16)
            {
                Console.WindowHeight = Console.LargestWindowHeight;
                Console.WindowWidth = Console.LargestWindowWidth;
            }
            
            for (int i = 0; i < row; i++) //вывод на экран
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.SetCursorPosition(column, i + 1); //параметры вывода (отступ, строка)
                    if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cell}"); //условие для вывода значений, отличных от 0 
                    column += cell * 2; //смещение вывода на два столбца
                }

                column = cell * row - cell * (i + 1); //расчёт вывода следующей строки
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
