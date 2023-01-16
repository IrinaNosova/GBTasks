// Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
// В задаче не использвать стандартный метод Pow!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



using static System.Console;

Write("Введите превое число a: ");
int.TryParse(ReadLine(), out int a);
Write("Введите число b: ");
int.TryParse(ReadLine(), out int b);

WriteLine($"{a} в степени {b} = {VozvStep(a,b)}");


int VozvStep (int A,int B)
{
    if (A == 0) return 0;
    int result = 1;
    for (int i=0; i<B; i++)
    result *= A;
    return result;
}
