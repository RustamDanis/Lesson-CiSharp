//int n = 10;
int[] array = { 1, 6, 2, 10, 8, 45, 4, 9, 8, 5 };
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}