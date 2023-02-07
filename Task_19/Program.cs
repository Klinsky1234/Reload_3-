/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
int a;
Console.WriteLine($"Введите пятизначное число: ");
int.TryParse(Console.ReadLine()!, out a);
string a1 = a.ToString();
int b = int.Parse(a1[0].ToString());
int b1 = int.Parse(a1[1].ToString());
int c = int.Parse(a1[3].ToString());
int c1 = int.Parse(a1[4].ToString());
if (b == c1 && b1 == c)
    Console.WriteLine($"{a} - является палиндромом");
else
    Console.WriteLine($"{a} - не хуя не является палиндромом!");