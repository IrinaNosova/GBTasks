//  Напишите программу, которая реализует рекурсивный метод нахождения суммы 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();

Write("Введите число M: ");
int numberM = Convert.ToInt32(ReadLine());
Write("Введите число N: ");
int numberN = Convert.ToInt32(ReadLine());


int SumNumbers(int minValue, int maxValue)
{
    if(minValue == maxValue) return maxValue;
    return SumNumbers(minValue + 1, maxValue) + minValue;
}
int sum = SumNumbers(numberM, numberN);
WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN}  = {sum}");