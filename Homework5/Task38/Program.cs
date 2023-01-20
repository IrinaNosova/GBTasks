// Напишите программу реализующую методы формирования массива, заполненного 
// случайными вещественными числами и вычисления разницы между максимальным 
// и минимальным элементов массива.
// [3,3 7,1 22,5 2,2 78,2] -> 76

using static System.Console;

Clear();
Write("Введите размер массива, мин и мах через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

double[] array = GetArray(int.Parse(parameters[0]),double.Parse(parameters[1]), double.Parse(parameters[2]));
PrintArray(array);
WriteLine($" - разница между мах и мин = {MinMaxDifr(array, 2)}");

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] resultArray = new double[size];
    Random rnd = new  Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.NextDouble()*(maxValue - minValue) + minValue;
    }
    return resultArray;
}
void PrintArray(double[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]:f2}  ");
    }
    Write($"{inArray[inArray.Length - 1]:f2}]");
}

double MinMaxDifr(double[] InnArr, uint round = 4)
{
    double max = InnArr[0];
    double min = InnArr[0];

    for (int i = 0; i < InnArr.Length; i++)
    {
        max = InnArr[i] > max ? InnArr[i] : max;
        min = InnArr[i] < min ? InnArr[i] : min;
    }

    return Math.Round(max - min, Convert.ToInt32(round));
}
