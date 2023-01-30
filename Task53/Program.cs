// Задайте двумерный массив. Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

using static System.Console;

Clear();
WriteLine("Введите размер матрицы через пробел: ");
string[] parametrs=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);


int[,] array=GetMatrixArray(int.Parse(parametrs[0]),int.Parse(parametrs[1]));

PrintMatrixArray(array);

WriteLine();

ChangeFirstAndLastRows(array);          

WriteLine();

int[,] GetMatrixArray(int rows, int columns)
{
    Random rnd=new Random();
    int[,] resultArray= new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i,j]= i+j;
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
            Write($"{inArray[i,j],3} ");
        }
        WriteLine();
    }
}

void ChangeFirstAndLastRows(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(1); i++) 
    {
        int result = inArray[0, i];
        inArray[0, i] = inArray[inArray.GetLength(0) - 1, i];
        inArray[inArray.GetLength(0) - 1, i] = result;
    }
    PrintMatrixArray(inArray);
}

