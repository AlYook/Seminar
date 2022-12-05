// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.

Console.WriteLine ("Enter X1 : ");
int Xa = int.Parse(Console.ReadLine());

Console.WriteLine ("Enter Y1 : ");
int Ya = int.Parse(Console.ReadLine());

Console.WriteLine ("Enter X2 : ");
int Xb = int.Parse(Console.ReadLine());

Console.WriteLine ("Enter Y2 : ");
int Yb = int.Parse(Console.ReadLine());

double AC = (Xb - Xa);
double BC = (Yb - Ya);

double AB = Math.Pow(AC, 2) + Math.Pow(BC, 2);

double result = Math.Sqrt(AB);

Console.WriteLine(result);
