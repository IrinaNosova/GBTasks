// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using static System.Console;

Write("Точка А - Введите координату x: ");
int.TryParse(ReadLine(),out int ax);
Write("Точка А - Введите координату y: ");
int.TryParse(ReadLine(),out int ay);
Write("Точка А - Введите координату z: ");
int.TryParse(ReadLine(),out int az);
Write("Точка Б - Введите координату x: ");
int.TryParse(ReadLine(),out int bx);
Write("Точка Б - Введите координату y: ");
int.TryParse(ReadLine(),out int by);
Write("Точка B - Введите координату z: ");
int.TryParse(ReadLine(),out int bz);

double length = Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2) + Math.Pow((az - bz), 2));

WriteLine($"{length:f2}");
