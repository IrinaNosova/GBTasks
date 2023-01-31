// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

using static System.Console;

Clear();
string result = GetNumbers(10);
WriteLine(result);
string result1 = GetNumbers1(10);
WriteLine(result1);
PrintNumbers(10);

string GetNumbers(int num)
{
    if (num == 1) return num.ToString();
    else return $"{GetNumbers(num - 1)},{num}";
}

// Теранарный оператор
string GetNumbers1(int num)
{
    return num==1?num.ToString(): $"{GetNumbers1(num - 1)},{num}";

// Второй способ решения
}
void PrintNumbers(int num)
{
    if (num == 1) Write(num);
    else
    {
        PrintNumbers(num - 1);
        Write($",{num}");
    }
}