
while (true)
{
Console.WriteLine("Введите целое число или q для выхода");
string inpt = Console.ReadLine();
if (inpt == "q")
{
    Console.WriteLine("Программа завершена");
    break;
}
int num;
if (int.TryParse (inpt, out num))
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    if (sum % 2 == 0)
    {
        Console.WriteLine("Введно число с четной суммой. Программа завершена");
        break;
    }
}
else
{
    Console.WriteLine("Введены неверные данные. Введите число или q");
}
}