Console.WriteLine("Введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10)
{
    Console.Write(num);
}
else
{
    while (num > 10)
    {
        int a = num % 10;
        num /= 10;
        if (num > 0)
        {
            Console.Write(a + ",");
        }
        else 
        {
            Console.Write(a);
        }
    }
}