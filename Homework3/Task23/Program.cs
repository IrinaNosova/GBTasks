using static System.Console;

int i = 1;
Write("Введите число: ");
int.TryParse(ReadLine(),out int n);

 while (i < n+1)
{
    WriteLine($"Квадрат числа{i} = {Math.Pow(i, 3)}");
    i ++;
}
