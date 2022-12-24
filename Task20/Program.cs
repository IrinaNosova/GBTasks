using static System.Console;
Clear();

Write("Введите координату х: ");
int x = int.Parse(ReadLine()!);
Write("Введите координату y: ");
int y = int.Parse(ReadLine()!);

{
    if(x > 0 && y > 0)
    {
        WriteLine("1 четверть");
    }
    if(x < 0 && y > 0)
    {
        WriteLine("2 четверть");
    }
    if(x < 0 && y < 0)
    {
        WriteLine("третья четверть");
    }
    if(x > 0 && y < 0)
    {
        WriteLine("четвертая четверть");
    }
else
    {
       WriteLine("Ошибка");
    }
}
