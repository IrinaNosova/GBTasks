﻿// Напишите программу реализующую метод, который возвращает массив размером 
// m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using static System.Console;

Clear();
WriteLine("Введите размер матрицы и диапозон значений через пробел: ");
string[] parametrs = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

//int[] intParams=Array.ConvertAll(ReadLine()!.Split(new char[]{'\"','#',';',',','s'},StringSplitOptions.RemoveEmptyEntries),int.Parse);
double[,] array = GetMatrixArray(int.Parse(parametrs[0]), int.Parse(parametrs[1]), int.Parse(parametrs[1]), int.Parse(parametrs[3]));

PrintMatrixArray(array);

double[,] GetMatrixArray(int rows, int columns, double minValue, double maxValue)
{
    Random rnd = new Random();
    double[,] resultArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rnd.NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return resultArray;
}

void PrintMatrixArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],5:f2}  ");
        }
        WriteLine();
    }
}