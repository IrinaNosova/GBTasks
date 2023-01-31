// Напишите программу, которая будет принимать на вход число и возвращать 
// сумму его цифр.
// 453 -> 12
// 45 -> 9


using static System.Console;
Clear();

Write("Введите число: ");
int number = Convert.ToInt32(ReadLine());
WriteLine($"Сумма цифр числа {number} = {SumElements(number)}");

int SumElements(int num)
{
    if (num == 0) return num;
    else return SumElements(num/10) + num%10;
}
