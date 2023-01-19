// Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

using static System.Console;
Clear();

Write("Введите размер массива, мин и мах через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

if (parameters.Length < 3)
{
    WriteLine("input not less than 3 numbers separated by space");
    return -1;
}

int[] IntParameters = new int[3];
for (int i = 0; i < 3; i++)
{
    if (!int.TryParse(parameters[i], out IntParameters[i]))
    {
        WriteLine("Please input only int values! now exit");
        return -1;
    }

}


int[] GeneratedArray = GenerateArray(IntParameters[0], IntParameters[1], IntParameters[2]);

PrintArray(GeneratedArray);
WriteLine();
SwitchElements(GeneratedArray);
PrintArray(GeneratedArray);

return 1;

void SwitchElements(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        inArray[i] = -inArray[i];
    }
}

int[] GenerateArray(int size, int begin, int end)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(begin, end + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Write($"{arr[i]}, ");
    }
    Write($"{arr[arr.Length - 1]}]");
    WriteLine();
}