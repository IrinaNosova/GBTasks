// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static System.Console;

Clear();
WriteLine("Введите размер матрицы и диапозон целых значений через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] matrix = GetMatrix(intParams[0], intParams[1], intParams[2], intParams[3]);
PrintMatrix(matrix);
WriteLine();
OrderArrayLines(matrix);
PrintMatrix(matrix);

int[,] GetMatrix(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultMatrix[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return resultMatrix;
}

void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j],3} ");
        }
        WriteLine();
    }
}


void OrderArrayLines(int[,] inArray1)
{
    for (int i = 0; i < inArray1.GetLength(0); i++)
    {
        for (int j = 0; j < inArray1.GetLength(1); j++)
        {
            for (int k = 0; k < inArray1.GetLength(1) - 1; k++)
            {
                if (inArray1[i, k] < inArray1[i, k + 1])
                {
                    int temp = inArray1[i, k + 1];
                    inArray1[i, k + 1] = inArray1[i, k];
                    inArray1[i, k] = temp;
                }
            }
        }
    }
}