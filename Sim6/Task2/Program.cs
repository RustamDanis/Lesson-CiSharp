// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]



void PrintArray(char[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

char[] StringToCharArray(string s)
{
    char[] arrStr = new char[s.Length];
    for (int i = 0; i < s.Length; i++)
    {
        arrStr[i] = s[i];
    }
    return arrStr;
}

Console.WriteLine("Введите слово!");
string str = Console.ReadLine();
char[]resArray = StringToCharArray(str);

PrintArray(resArray);
