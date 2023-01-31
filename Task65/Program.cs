// Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

using static System.Console;

Clear();


PrintNumbers(10, 5);
WriteLine();
WriteLine(PrintNumbers1(10, 5));
WriteLine(PrintNumbers2(10, 5));
WriteLine(GetNumbers1(5, 10));
//Способ 1
string PrintNumbers1(int start, int end)
{
    if (end == start) return start.ToString();
    if (start < end)
        return $"{PrintNumbers1(start, end - 1)},{end}";
    else
        return $"{PrintNumbers1(end, start - 1)},{start}";
}
// Способ 2
string PrintNumbers2(int start, int end)
{
    if (end == start) return end.ToString();
    return (start < end) ? $"{PrintNumbers2(start, end - 1)},{end}"
                         : $"{PrintNumbers2(end, start - 1)},{start}";

}
// Способ 3
string GetNumbers1(int start, int end)
{
    return start > end ? (start == end ? start.ToString() : $"{GetNumbers1(start - 1, end)}, {start}")
                       : (end == start ? end.ToString() : $"{GetNumbers1(end - 1, start)}, {end}");
}
// Способ 4
void PrintNumbers(int start, int end)
{
    if (start > end)
    {
        int temp = start;
        start = end;
        end = temp;
    }
    if (end == start) Write(end);
    else
    {
        PrintNumbers(start, end - 1);
        Write($",{end}");
    }
}