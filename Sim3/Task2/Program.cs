﻿//Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. Замените отрицательные 
//элементы на положительные, а положительные на отрицательные.
//Пример

//[1 -5 6]
//=> [-1 5 -6]



int[] array = new int [10] {-3, 4, -5, 6, 8, -4, 7, 9, -1, 3};

for (int i = 0; i <array.Length; i++)
{
        array[i] *= -1; //array[i] = array[i] * -1
              
}

for (int i = 0; i <array.Length; i++)
{
            Console.Write(array[i] + " ");
}
