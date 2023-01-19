//  Напишите программу реализующую методы формирования массива, заполненного 
// случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


using static System.Console;

Clear();
Write("Введите размер массива, мин и мах через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(parameters[0]),int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(array);

WriteLine();


int sum = GetSummNumbersOddndex(array);
WriteLine($"Сумма значений нечетных индексов массива = {sum}");
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];
    Random rnd = new  Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(minValue, maxValue + 1);
    }
    return resultArray;
}
void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}

int GetSummNumbersOddndex(int[] inArray)
{
    int result = 0; 

    for (int i = 0; i < inArray.Length; i++)
    {                                                                      
        if (i % 2 == 1)  
            result += inArray[i];  
    }

    return result;  
}
