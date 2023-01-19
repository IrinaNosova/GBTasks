//  Напишите программу реализующую методы формирования массива, заполненного 
// случайными положительными трёхзначными числами, и подсчета количества чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;

WriteLine("Введите размер массива: ");
int enter = int.Parse(ReadLine()!); 
int [] arr = GetArray(enter);

PrintArray(arr);

int count = CountElements(arr);
string I = String.Join(", ", count);

Write($"четных элементов - [{I}]");

int[] GetArray (int size)
{
    int [] array = new int [size];
for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(100, 1000); 
}
return array;
}

void PrintArray (int [] array)
{
for (int i = 0; i < array.Length; i++)
{
    Write($"{array[i]} ");
}
}
int CountElements(int[] inArray)
{
    int count = 0;
    foreach (int item in inArray)
    {
        if (item % 2 == 0)
        {
            count++;
        }
    }
    return count;
}