// Задайте двумерный массив. Напишите программу, которая заменяет строки на 
// столбцы. В случае, если это невозможно, программа должна вывести сообщение 
// для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7


using static System.Console;
Clear();
WriteLine("Введите размер матрицы и диапозон значений через пробел: ");
string[] parametrs = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);


int[,] array = GetMatrixArray(int.Parse(parametrs[0]), int.Parse(parametrs[1]), int.Parse(parametrs[2]), int.Parse(parametrs[3]));

PrintMatrixArray(array);

WriteLine();

NewMatrix(array);

WriteLine();


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
            Write($"{inArray[i, j],3} ");
        }
        WriteLine();
    }
}
void NewMatrix(int[,] inArray)
{
    int[,] result = new int[inArray.GetLength(0), inArray.GetLength(1)];

    if (inArray.GetLength(0) != inArray.GetLength(1))
    {

        WriteLine("Невозможно заменить строки на столбцы, матрица должна быть квадратной!");

    }

    else
    {

        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                result[j, i] = inArray[i, j];
            }
        }
        PrintMatrixArray(result);
    }
}