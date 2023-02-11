/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
int Ax, Bx, Ay, By, Az, Bz;
Console.WriteLine($"Введите коордлинаты х токи А: ");
int.TryParse(Console.ReadLine()!, out Ax);
Console.WriteLine($"Введите коордлинате х токи B: ");
int.TryParse(Console.ReadLine()!, out Bx);
Console.WriteLine($"Введите коордлинаты y токи А: ");
int.TryParse(Console.ReadLine()!, out Ay);
Console.WriteLine($"Введите коордлинаты y токи B: ");
int.TryParse(Console.ReadLine()!, out By);
Console.WriteLine($"Введите коордлинаты z токи А: ");
int.TryParse(Console.ReadLine()!, out Az);
Console.WriteLine($"Введите коордлинаты z токи B: ");
int.TryParse(Console.ReadLine()!, out Bz);

/* double x = (Bx - Ax) * (Bx - Ax);
double y = (By - Ay) * (By - Ay);
double z = (Bz - Az) * (Bz - Az);
double xyz = x + y + z;
double ans = Math.Round(Math.Sqrt(xyz), 2);
Console.WriteLine($"Расстояние: {ans}"); */

double otvet = Math.Round(Math.Sqrt(Fun(Bx, Ax) + Fun(By, Ay) + Fun(Bz, Az)), 2);
Console.WriteLine($"Расстояние: {otvet}");
double Fun(double x, double y)
{
    return (x - y) * (x - y);
}