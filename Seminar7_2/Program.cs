﻿//  Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5



Console.Write("Введите количество строк массива: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов массива: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] array = GetArrayMatrix(rows, columns);
            PrintArray(array);

            int[,] GetArrayMatrix(int rows, int columns)
            {
                int[,] result = new int[rows, columns];


                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        result[i, j] = i + j;
                    }
                }
                return result;
            }

            void PrintArray(int[,] inArray)
            {
                for (int i = 0; i < inArray.GetLength(0); i++)
                {
                    for (int j = 0; j < inArray.GetLength(1); j++)
                    {
                        Console.Write($"{inArray[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
            
