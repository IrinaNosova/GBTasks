using static System.Console;

Write("Введите число a: ");
int a = int.Parse(ReadLine()!);
Write("Введите число b: ");
int b = int.Parse(ReadLine()!);

int max = a;

if (a > b)
{
    Write("max= ");
    WriteLine(a);
}
else
{
    Write("max= ");
    WriteLine(b);
}