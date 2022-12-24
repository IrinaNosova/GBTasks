using static System.Console;

Write("Введите число: ");
int day = Convert.ToInt32(ReadLine());

switch(day)
{
    case 1:
    {
        WriteLine("Понедельник");
        break;
    }
    case 2:
    {
        WriteLine("Вторник");
        break;
    }
    case 3:
    {
        WriteLine("Срела");
        break;
    }
    case 4:
    {
        WriteLine("Четверг");
        break;
    } 
     case 5:
    {
        WriteLine("Пятница");
        break;
    }
    case 6:
    {
        WriteLine("Суббота");
        break;
    }
    case 7:
    {
        WriteLine("Воскресенье");
        break;
    } 
    default:
    {
        Write("Данного дня недели не существует");
        break;
    }
}

