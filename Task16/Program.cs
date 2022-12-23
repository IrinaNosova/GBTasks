using static System.Console;
Clear();
WriteLine("Введите число: ");
int a = Convert.ToInt32(ReadLine());

WriteLine(a%7 == 0 && a%23 == 0? "кратно":"некратно");
