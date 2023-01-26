//  Напишите программу реализующую методы, формирования двумерного массива и
// массива средних арифметических значений каждого столбца.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;

Clear();
WriteLine("Введите размер матрицы и диапозон значений через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);
PrintMatrixArray(array);
WriteLine();
WriteLine($"{string.Join("; ", GetAverageColumnArray(array))}");

double[] GetAverageColumnArray(int[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)];

    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        int j = 0;
        for (; j < inArray.GetLength(0); j++)
        {
            result[i] += inArray[j, i];
        }
        result[i] = Math.Round((result[i] / j), 1);
    }

    return result;
}

int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],5} ");
        }
        WriteLine();
    }
}