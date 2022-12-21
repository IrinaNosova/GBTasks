using static System.Console;

WriteLine("Введите число:");
int n = int.Parse(ReadLine()!);
int a = 1;

while ( a < n )
{
    if ( a % 2 == 0)
    Write($"{a} ");
    a = a + 1;
}