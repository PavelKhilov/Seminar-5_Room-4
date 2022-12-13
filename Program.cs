﻿// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных элементов массива.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
//        Console.WriteLine($"{i + 1} element is {array[i]}");
    }    
    Console.WriteLine( );
}

int GetSumOfNegatives (int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if(array[i] < 0)
            sum += array[i];
    return sum;
}

Console.Write("Input number elements: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min psible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max psible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(lenght, min, max);
ShowArray(myArray);

int result = GetSumOfNegatives(myArray);
Console.WriteLine($"Sum of negatives elements is {result}");
