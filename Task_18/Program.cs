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
int a;
Console.WriteLine($"Введите a ");
int.TryParse(Console.ReadLine()!, out a);

switch (a)// свитч смотрит на значение переменной и перебрасывает на тот кейс чему равна переменная х, если 3, то 3 кейс
{
    case 1:
        Console.WriteLine($"X > 0 Y > 0");
        break;
    case 2:
        Console.WriteLine($"X < 0 Y > 0");
        break;
    case 3:
        Console.WriteLine($"X < 0 Y < 0");
        break;
    case 4:
        Console.WriteLine($"X > 0 Y < 0");
        break;
    default:
        break;
}
