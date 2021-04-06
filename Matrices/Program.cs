using System;
using System.Threading;

namespace Matrices
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Что будем делать?\n\nУмножать матрицу на число - нажмите 1\nСкладывать и вычитать две матрицы - нажмите 2\nУмножить одну матрицу на другую - нажмите 3");
            Console.WriteLine("\nДля выхода нажмите 4");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "1":
                    #region Умножение матрицы на число

                    Console.Clear();
                    Console.WriteLine("\nВведите количество строк и столбцов матрицы");
                    Console.Write("Строк: ");
                    int row = int.Parse(Console.ReadLine());
                    Console.Write("Столбцов: ");
                    int columns = int.Parse(Console.ReadLine());
                    if (row <= 0 || columns <= 0)
                    {
                        Console.WriteLine("\nЗначение не может быть меньше иди равно нулю. Придётся начать заново");
                        Thread.Sleep(2000);
                        Main();
                    }
                    Console.Write("Введите множитель: ");
                    int factor = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine();

                    Random random = new Random();

                    int[,] arr = new int[row, columns];

                    Console.WriteLine("Исходная матрица: ");

                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            arr[i, j] = random.Next(10);
                            Console.Write($"{arr[i, j]} ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();

                    Console.WriteLine($"Результат умножения на {factor}: ");

                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            arr[i, j] = arr[i, j] * factor;
                            Console.Write($"{arr[i, j]} ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                    Console.WriteLine($"Если хотите посчитать что-нибудь ещё, нажмите 1");
                    string repeat = Console.ReadLine();

                    if (repeat == "1")
                    {
                        Main();
                    }
                    else
                    {
                        break;
                    }

                    #endregion
                    break;

                case "2":
                    #region Сложение и вычитание двух матриц

                    Console.Clear();
                    Console.WriteLine("\nВведите количество строк и столбцов. Эти значения будут использованы\nдля обеих матриц, потому что складывать\nи вычитать можно только матрицы одинакового размера");
                    Console.Write("Строк: ");
                    int row1 = int.Parse(Console.ReadLine());
                    Console.Write("Столбцов: ");
                    int columns1 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (row1 <= 0 || columns1 <= 0)
                    {
                        Console.WriteLine("\nЗначение не может быть меньше или равно нулю. Придётся начать заново");
                        Thread.Sleep(2000);
                        Main();
                    }

                    Random random1 = new Random();

                    int[,] arr1 = new int[row1, columns1];
                    int[,] arr2 = new int[row1, columns1];


                    Console.WriteLine("Исходные матрицы: ");

                    for (int i = 0; i < row1; i++)
                    {
                        for (int j = 0; j < columns1; j++)
                        {
                            arr1[i, j] = random1.Next(10);
                            Console.Write($"{arr1[i, j]} ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();

                    for (int i = 0; i < row1; i++)
                    {
                        for (int j = 0; j < columns1; j++)
                        {
                            arr2[i, j] = random1.Next(10);
                            Console.Write($"{arr2[i, j]} ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                    Console.WriteLine("Сумма матриц");

                    int[,] arr_sum = new int[row1, columns1];

                    for (int i = 0; i < row1; i++)
                    {
                        for (int j = 0; j < columns1; j++)
                        {
                            arr_sum[i, j] = arr1[i, j] + arr2[i, j];
                            Console.Write($"{arr_sum[i, j]} ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                    Console.WriteLine("Разность матриц");

                    int[,] difference = new int[row1, columns1];

                    for (int i = 0; i < row1; i++)
                    {
                        for (int j = 0; j < columns1; j++)
                        {
                            difference[i, j] = arr1[i, j] - arr2[i, j];
                            Console.Write($"{difference[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                    
                    Console.WriteLine();
                    Console.WriteLine("Если хотите посчитать что-нибудь ещё, нажмите 1");
                    string repeat1 = Console.ReadLine();

                    if (repeat1 == "1")
                    {
                        Main();
                    }
                    else
                    {
                        break;
                    }

                    #endregion
                    break;

                case "3":
                    #region Умножение матриц

                    Console.Clear();
                    Console.WriteLine("\nВведите количество строк и столбцов. Умножать матрицы можно тогда и только тогда,\nкогда количество столбцов первой матрицы\nравно количеству строк второй матрицы");
                    Console.Write("Строк первой матрицы: ");
                    int row2 = int.Parse(Console.ReadLine());
                    Console.Write("Столбцов первой матрицы и строк второй матрицы: ");
                    int columns2 = int.Parse(Console.ReadLine());
                    int row3 = columns2;
                    Console.Write("Столбцов второй матрицы: ");
                    int columns3 = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    if (row2 <= 0 || columns2 <= 0 || columns3 <= 0)
                    {
                        Console.WriteLine("\nЗначение не может быть меньше или равно нулю. Придётся начать заново");
                        Thread.Sleep(2000);
                        Main();
                    }

                    Random random2 = new Random();

                    int[,] arr3 = new int[row2, columns2];
                    int[,] arr4 = new int[row3, columns3];


                    Console.WriteLine("Исходные матрицы: ");

                    for (int i = 0; i < row2; i++)
                    {
                        for (int j = 0; j < columns2; j++)
                        {
                            arr3[i, j] = random2.Next(10);
                            Console.Write($"{arr3[i, j]} ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();

                    for (int i = 0; i < row3; i++)
                    {
                        for (int j = 0; j < columns3; j++)
                        {
                            arr4[i, j] = random2.Next(10);
                            Console.Write($"{arr4[i, j]} ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                    Console.WriteLine("Произведение матриц");


                    int [,] prod_of_arrs = new int[arr3.GetLength(0), arr4.GetLength(1)];

                    for (int i = 0; i < arr3.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr4.GetLength(1); j++)
                        {
                            for (int k = 0; k < arr4.GetLength(0); k++)
                            {
                                prod_of_arrs[i, j] += arr3[i, k] * arr4[k, j];
                            }
                        }
                    }

                    for (int i = 0; i < prod_of_arrs.GetLength(0); i++)
                    {
                        for (int j = 0; j < prod_of_arrs.GetLength(1); j++)
                        {
                            Console.Write($"{prod_of_arrs[i, j]} ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                    Console.WriteLine("Если хотите посчитать что-нибудь ещё, нажмите 1");
                    string repeat2 = Console.ReadLine();

                    if (repeat2 == "1")
                    {
                        Main();
                    }
                    else
                    {
                        break;
                    }

                    #endregion
                    break;

                case "4":
                    break;

                default:
                    Main();
                    break;
            }
        }
    }
}
