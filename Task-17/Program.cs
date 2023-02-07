/* Напишите программу, которая принимает на вход координаты точки ( X,Y ),
причём х не равно нулю и y не равно нулю и выдаёт номер четверти*/
int x, y;
Console.WriteLine($"Enter X: ");
int.TryParse(Console.ReadLine()!, out x);
Console.WriteLine($"Enter Y: ");
int.TryParse(Console.ReadLine()!, out y);

if (x > 0 && y > 0)
    Console.WriteLine($"1");
else if (x < 0 && y > 0)
    Console.WriteLine($"2");
else if (x < 0 && y < 0)
    Console.WriteLine($"3");
else if (x > 0 && y < 0)
    Console.WriteLine($"2");
