using static System.Console;

WriteLine("Является ли одно число квадратом другого числа?");
Write("Введите число a: ");
int a = int.Parse(ReadLine()!);
Write("Введите число b: ");
int b = int.Parse(ReadLine()!);

WriteLine(a * a == b || b * b == a? "является" : "не является");