//Напишите программу, которая принимает на вход число (А) и выдаёт сумму 
// чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

using static System.Console;
Clear();
Write("Input number: ");
int number = int.Parse(ReadLine()!);

int sum = GetSum(number);
WriteLine($"Sum number 1 .. A = {sum}");






int GetSum(int A)
{
    int result = 0;
    while(A > 0)
    {
        result += A;
        A --;
    }
    return result;
}