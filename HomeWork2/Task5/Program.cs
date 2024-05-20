class Program
{
    static void Main()
    {
        int[] numbers = { 2, 5, 8, 10, 13, 17, 20, 24, 30, 35 };
        int evenCount = 0;

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        Console.WriteLine(evenCount);
    }
}