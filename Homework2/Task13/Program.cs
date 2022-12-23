using static System.Console;

Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()!);

 while (number > 1000)
{
    number = number/10;
}
WriteLine(number%10);
if (number < 100)
{
    WriteLine("Третьей цифры нет");

}