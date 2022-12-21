using static System.Console;

Write("Введите число: ");
int a = int.Parse(ReadLine()!);

if (a%2 == 0)
{
    WriteLine("Да");
}
else
{
    WriteLine("Нет");
}
