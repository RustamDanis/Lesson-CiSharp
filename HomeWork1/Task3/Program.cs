Console.WriteLine("Введите число из отрезка от 10 до 90");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10 && num <= 90)
{
int firstNum = num / 10;
int secNum = num % 10;
int maxNum = firstNum > secNum ? firstNum : secNum;
Console.WriteLine(maxNum);
}
else
{
    Console.WriteLine("Введно неверное число");
}