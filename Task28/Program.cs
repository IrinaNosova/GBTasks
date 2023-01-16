// Напишите программу, которая принимает на вход число и выдаёт 
// количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

using static System.Console;
Clear();
Write("Input number: ");

int number = int.Parse(ReadLine()!);

WriteLine($"Количество цифр в числе {number} - {GetMult(number)}");


int GetMult(int A)
{
    if (A <= 0) return 0;

    int result = 0;
    while (A > 0)
    {
        A /= 10;
        result ++;
    }
    return result;
}