// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой 
// считаем первый и последний элемент, второй и предпоследний и т.д. Результат 
// запишите в новом массиве.

using static System.Console;
Clear();

int[] GeneratedArray = GenerateArray(5, 1, 2);

PrintArray(GeneratedArray);
WriteLine("result:");

int[] PairArray = NewPairMult(GeneratedArray);

PrintArray (PairArray);


int[] NewPairMult(int[] InArray)
{
    int length = InArray.Length;
    length += (length % 2 == 1)? 1: 0;
    WriteLine($"lenght = {length}");
    int[] NewArray = new int[length/2];
    for(int i=0; i < (length /2) ; i++)
    {

        NewArray[i] = InArray[i] * InArray[InArray.Length - i - 1];

    }
    return NewArray;
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