// Напишите программу, которая принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

using static System.Console;
Clear();
Write("Input number: ");

int.TryParse(ReadLine(), out int N);

WriteLine($"Произведение чисел от 1...{N} = {NumProduct(N)}");

int NumProduct(int num)
{
    int result = 1;
    while(num > 0)
    {
        result *= num;
        num --;
    }
    return result;
}