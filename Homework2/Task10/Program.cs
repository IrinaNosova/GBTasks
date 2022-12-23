using static System.Console;

Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(ReadLine());

WriteLine(number < 1000 && number > 99? number % 100 / 10 : "Введено не трёхзначное число");