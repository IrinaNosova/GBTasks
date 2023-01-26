// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

using static System.Console;

Clear();
WriteLine("Введите размер матрицы и диапозон значений через пробел: ");
string[] parametrs = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

//int[] intParams=Array.ConvertAll(ReadLine()!.Split(new char[]{'\"','#',';',',','s'},StringSplitOptions.RemoveEmptyEntries),int.Parse);
int[,] array = GetMatrixArray(int.Parse(parametrs[0]), int.Parse(parametrs[1]), int.Parse(parametrs[1]), int.Parse(parametrs[3]));

PrintMatrixArray(array);

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