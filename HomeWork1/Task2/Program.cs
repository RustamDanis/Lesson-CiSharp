Console.WriteLine(" Введите число Х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Введите число y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в 1 зон оси координат");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится в 2 зон оси координат");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в 3 зон оси координат");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в 4 зон оси координат");
}
else
{
    Console.WriteLine("Точка находится на оси коорднат");
}
