// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Write($"Значения среднего арифметического в каждом столбце равны: {String.Join("; ", Average(array))}");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
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
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

// Метод для нахождения среднего арифметического в каждом столбце двумерного массива.
string[] Average(int[,] inArray)
{
    string[] averageColumn = new string[inArray.GetLength(1)];
    for (int j = 0; j < inArray.GetLength(1); j++)// Перебираем столбцы.
    {
        double sum = 0;
        for (int i = 0; i < inArray.GetLength(0); i++){// Перебираем строки.
        sum += inArray[i, j];// Складываем все элементы столбца.
        }
        averageColumn[j] = string.Format("{0:F2}", (sum / inArray.GetLength(0)));// Записываем округленное значение среднего арифметического в массив строк.
    }
    return averageColumn;
}    