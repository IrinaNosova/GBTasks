﻿using static System.Console;
Clear();

WriteLine("Введите пятизначное число: ");
int.TryParse(ReadLine(),out int number);

if(number < 100000 && number > 9999)
{
    int a = number%100; int b = number/1000;
    
    Write(a/10 == b%10 && a%10 == b/10?"Число является палиндромом":"Число не является палиндромом");
}
else
{
    WriteLine("Число введено неверно");
}

