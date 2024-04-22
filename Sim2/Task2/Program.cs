
Console.WriteLine("Введите целое трезначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int secondDigit = num / 10 % 10;
    int thirdDigit = num % 10;
    int result = secondDigit; //double result = Math.Pow(secondDigit, thirdDigit);
    int count = 1;
    while (count < thirdDigit)
    {
        result = result * secondDigit; //result *= secondDigit
        count++;
    }
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Введено неверное число");
}