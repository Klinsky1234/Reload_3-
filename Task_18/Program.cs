/* Напишите прогу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти*/
int x;
Console.WriteLine($"Введите номер четверти");
int.TryParse(Console.ReadLine()!, out x);

if (x == 1)
    Console.WriteLine($"X > 0 Y > 0");
else if (x == 2)
    Console.WriteLine($"X < 0 Y > 0");
else if (x == 3)
    Console.WriteLine($"X < 0 Y < 0");
else if (x == 4)
    Console.WriteLine($"X > 0 Y < 0");
else
    Console.WriteLine($"Неверный ввод");
