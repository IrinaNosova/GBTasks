// Напишите программу, реализующую метод, который принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


using static System.Console;
Clear();
Write("Введите число: ");

int number = int.Parse(ReadLine()!);
int sum = GetSum(number);

WriteLine($"Сумма чисел {number} = {sum}");



int GetSum(int A)
{
    int result = 0;
    while(A > 0)
    {
        result += A%10;
        A/=10;
       
    }
    return result;
}




