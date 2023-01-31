// Напишите программу, которая на вход принимает два числа A и B, и возводит 
// число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

using static System.Console;
Clear();

Write("Введите число A: ");
int numberA = Convert.ToInt32(ReadLine());
Write("Введите число B: ");
int numberB = Convert.ToInt32(ReadLine());

WriteLine(InDegree(numberA, numberB));

int InDegree(int num1, int num2)
{
          if (num2 == 1) return num1;
          else return InDegree(num1, num2 - 1) * num1;
}