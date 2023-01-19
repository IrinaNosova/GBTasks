// **Задача 33:** Задайте массив. Напишите программу, которая определяет,
//  присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да



using static System.Console;
Clear();

Write("Введите размер массива, мин и мах и искомый элемент через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] IntParameters = new int[4];
if (parameters.Length < 4)
{
    WriteLine("Not less than 4 parameters are expected(separate by space). Now exit!");
    return -1;
}
for(int i =0; i < 4; i++)
{
    if(! int.TryParse(parameters[i], out IntParameters[i]))
    {
        WriteLine($"error! parameter{i} can't be converted to int");
        return -1;
    }
}


int[] GeneratedArray = GenerateArray(IntParameters[0], IntParameters[1], IntParameters[2]);
PrintArray(GeneratedArray);
WriteLine();

if (IsNumberinArray(IntParameters[3], GeneratedArray))
{
    WriteLine($"число {IntParameters[3]} присутствует в массиве");
  
}
else
{
WriteLine($"число {IntParameters[3]} отсутствует в массиве");
}

return 0;

bool IsNumberinArray(int number, int[] inArray)
{
    for(int i=0; i< inArray.Length; i++)
    {
        if (inArray[i] == number)
        {
            return true;
        }
    }
    return false;
}

int[] GenerateArray(int size, int begin, int end)
 {
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(begin, end+1);
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
