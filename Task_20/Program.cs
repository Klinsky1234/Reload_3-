/* 20. Напишите программу, которая принимает на вход координаты 2х точек и находит расстояние между нимив 2D пространстве
A(3,6); B (2,1) -> 5,09
*/
int Ax, Bx, Ay, By;
Console.WriteLine($"Введите коордлинате х токи А: ");
int.TryParse(Console.ReadLine()!, out Ax);
Console.WriteLine($"Введите коордлинате х токи B: ");
int.TryParse(Console.ReadLine()!, out Bx);
Console.WriteLine($"Введите коордлинате y токи А: ");
int.TryParse(Console.ReadLine()!, out Ay);
Console.WriteLine($"Введите коордлинате y токи B: ");
int.TryParse(Console.ReadLine()!, out By);

/*  double x = (Bx - Ax) * (Bx - Ax);// мы находим квадрат 
double y = (By - Ay) * (By - Ay);
double xy = x + y;
double ans = Math.Round(Math.Sqrt(xy), 2); // находим корень и  мафроунд округляет до 2 
Console.WriteLine($"Расстояние: {ans}"); - это одно решение */

/* можно решить слудующим способом
double x = PointSqr(Bx,Ax); - PointSqr такое название взяли, типа возведение какой-то точки в квадрат 
double y = PointSqr(By,Ay);
double xy = x + y;
double ans = Math.Round(Math.Sqrt(xy), 2);
double PointSqr(double x, double y)
{
    return (x - y) * (x - y);
}  - это первый шаг 
потом вместо х подставляем PointSqr(Bx - Ax), а вместо y -> PointSqr(By - Ay)
*/

double ans = Math.Round(Math.Sqrt(PointSqr(Bx, Ax) + PointSqr(By, Ay)), 2); // xy = x + y, поэтому вместо xy мы подставляем эту хуиту
Console.WriteLine($"Расстояние: {ans}");
double PointSqr(double x, double y)
{
    return (x - y) * (x - y);
}