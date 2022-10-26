// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Ax1, Ay1, Az1, Bx2, By2, Bz2;
double resultDoub;

Console.WriteLine("Введите координаты точек A и B: ");
Console.Write("Точка A_x1: ");
Ax1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка A_y1: ");
Ay1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка A_z1: ");
Az1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Точка B_x2: ");
Bx2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка B_y2: ");
By2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка B_z2: ");
Bz2 = Convert.ToInt32(Console.ReadLine());

resultDoub = Math.Pow(Bx2 - Ax1, 2) + Math.Pow(By2 - Ay1, 2) + Math.Pow(Bz2 - Az1, 2);
resultDoub = Math.Sqrt(resultDoub);
resultDoub = Math.Round(resultDoub, 2);

Console.WriteLine($"Расстояние = {resultDoub}");