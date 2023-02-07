/* 22. Напишите прогу, которая принимает на вход числ N и выдаёт таблицу квадартов чисел от 1 до N
5 -> 1,4,9,16,25 */

int a;
Console.WriteLine($"Введите a: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"{5} -> ");
for (int i = 1; i <= a; i++)
{
    int sum = i * i;
    Console.Write($"{sum} ");
}