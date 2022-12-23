using static System.Console;
Clear();
WriteLine("Введите число a: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число b: ");
int b = Convert.ToInt32(ReadLine());

WriteLine (a == b? "=":a>b? ">":"<");