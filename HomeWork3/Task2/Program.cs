int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

int CountSqrNumbers(int[] array)
{
    int count = 0;
    //Реализация подсчета простых чисел;
    for (int i = 0; i < array.Length; i++)
    {
        if (IsSqr(array[i]))
        {
            count++;
        }
    }



    return count;
}

bool IsSqr(int num)
{
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % 2 == 0)
        {
            return true;
        }
    }
    return false;
}


int[] arr = CreateArrayRndInt(10, 100, 1000);
PrintArray(arr);

int countSqr = CountSqrNumbers(arr);
Console.Write($" => {countSqr}");