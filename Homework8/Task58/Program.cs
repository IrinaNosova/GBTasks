//  Задайте две матрицы. Напишите программу, которая будет находить 
//  произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static System.Console;

Clear();

WriteLine("Введите размер первой матрицы и диапозон значений через пробел: ");
string[] parametrs = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetMatrixArray(int.Parse(parametrs[0]), int.Parse(parametrs[1]), int.Parse(parametrs[1]), int.Parse(parametrs[3]));

PrintMatrixArray(array);

WriteLine("Введите размер второй матрицы и диапозон значений через пробел: ");
string[] parametrs2 = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array2 = GetMatrixArray(int.Parse(parametrs[0]), int.Parse(parametrs[1]), int.Parse(parametrs[1]), int.Parse(parametrs[3]));

PrintMatrixArray(array2);
WriteLine("Результирующая матрица: ");

int[,] resultMatrixArray = MultiMatrix(array, array2);
PrintMatrixArray(resultMatrixArray);
int[,] MultiMatrix(int[,] inArray1, int[,] inArray2)
{
    
    int[,] resultMatrix = new int[inArray1.GetLength(0), inArray2.GetLength(1)];
    for (int i = 0; i < inArray1.GetLength(0); i++)
    {
        for (int j = 0; j < inArray2.GetLength(1); j++)
        {
            for (int k = 0; k < inArray2.GetLength(0); k++)
            {
                resultMatrix[i, j] += inArray1[i, k] * inArray2[k, j];
            }
        }
    }
    return resultMatrix;
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


