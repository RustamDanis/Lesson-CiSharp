
int x = 0;
int y = -8;

if (x > 0 && y > 0)
{
    Console.WriteLine("Первая четверть");
}

else if (x < 0 && y > 0)
{
    Console.WriteLine("Вторая четверть");
}

else if (x < 0 && y < 0)
{
    Console.WriteLine("Третья четверть");
}

else if (x > 0 && y < 0)
{
    Console.WriteLine("Четвертая четверть");
}

else
{
    Console.WriteLine("Incorrect");
}
