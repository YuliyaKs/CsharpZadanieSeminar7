// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

double[,] array = GetArray(rows, columns, -10, 10);// Задаем массив вещественных чисел.
PrintArray(array);// Вывод массива.

// Метод для создания массива, заполненного случайными вещественными числами.
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return result;
}

// Метод для вывода на экран элементов массива с округлением до 1 знака после запятой.
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]:f1} ");
        }
        WriteLine();
    }
}