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

int x = (Bx - Ax) * (Bx - Ax);// мы находим квадрат 
int y = (By - Ay) * (By - Ay);
int xy = x + y;
double ans = Math.Round(Math.Sqrt(xy), 2); // находим корень и  мафроунд округляет до 2 
Console.WriteLine($"Расстояние: {ans}");