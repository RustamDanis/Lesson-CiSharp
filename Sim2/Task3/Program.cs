Console.WriteLine(" Input first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Input second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int remainder = firstNumber % secondNumber;

if (remainder == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No, " + remainder);
}