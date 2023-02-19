// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

Write($"Введите {rows * columns} элементов через пробел: ");
string[] stringArray = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);// Преобразуем строку, введенную пользователем, в массив.

int[,] array = GetArray(stringArray, rows, columns);// Преобразуем массив строк в двумерный массив чисел. 
PrintArray(array);

Write("Введите индекс строки и индекс столбца через пробел: ");
string[] indexes = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Write(FindElement(array, indexes));// Выводим сообщение о результате поиска элемента по индексам с помощью метода.

// Метод преобразует одномерный массив строк в двумерный массив чисел.
int[,] GetArray(string[] strArray, int m, int n)
{
    int[,] result = new int[m, n];
    int k = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = int.Parse(strArray[k]);
            k++;
        }
    }
    return result;
}

// Метод для вывода на экран элементов массива.
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

// Метод для нахождения значения элемента по его позиции в двумерном массиве.
string FindElement(int[,] inArray, string[] index)
{
    int m = int.Parse(index[0]);
    int n = int.Parse(index[1]);
    string otvet = "Такого числа в массиве нет";
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i == m && j == n){
                otvet = $"Число на позиции ({m}, {n}) равно {inArray[i, j]}";
            }
        }
    }
    return otvet;    
}