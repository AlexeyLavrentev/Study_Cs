// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты точки A");
Console.Write("X = : ");
int Ax = int.Parse(Console.ReadLine());
Console.Write("Y = : ");
int Ay = int.Parse(Console.ReadLine());
Console.Write("Z = : ");
int Az = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("X = : ");
int Bx = int.Parse(Console.ReadLine());
Console.Write("Y = : ");
int By = int.Parse(Console.ReadLine());
Console.Write("Z = : ");
int Bz = int.Parse(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2) + Math.Pow(Az - Bz, 2));
Console.WriteLine("Расстояние: " + Math.Round(AB, 2));