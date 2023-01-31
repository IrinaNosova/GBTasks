// Напишите программу реализующую метод вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using static System.Console;
Clear();

Write("Введите первое неотрицательное число m: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Write("Введите второе неотрицательное число n: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

int Ackerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return Ackerman (m - 1, 1);
return Ackerman (m - 1, Ackerman (m, n - 1));
}
int result = Ackerman(numb1, numb2);
WriteLine($"A(m,n) = {result}");
