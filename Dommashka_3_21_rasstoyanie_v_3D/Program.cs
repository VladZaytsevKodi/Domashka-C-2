// Напишите программу, которая на вход принимает координаты 2х точек и 
// находит расстоние между ними в пространстве 3D

Console.Clear();
int xa = 3, ya = 6, za = 8,
    xb = 2, yb = 1, zb = -7;

double distance = Math.Sqrt((Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2)));
Console.WriteLine($"расстояние между двумя токами {distance}");
