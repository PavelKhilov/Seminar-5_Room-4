// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
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
/*
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
*/

// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
int[] Reverse (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= -1;
    return array;
}
/*
Console.Write("Input number elements: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min psible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max psible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(lenght, min, max);
ShowArray(myArray);
int[] newArray = Reverse(myArray);
ShowArray(newArray);
*/
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
bool FindNumber (int[] array, int N)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == N)
            return true; 
    }
    return false;
}
/*
Console.Write("Input number elements: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min psible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max psible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input find number N = ");
int N = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(lenght, min, max);
ShowArray(myArray);

bool result = FindNumber (myArray, N);
Console.Write($"The find number N - {result}");
*/

// Задайте массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
int FindFragment (int[] array, int a, int b)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= a && array[i] <= b)
            count++;
    }
    return count;
}

Console.Write("Input number elements: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min psible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max psible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min psible value on diapasone A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max psible value on diapasone B: ");
int B = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(lenght, min, max);
ShowArray(myArray);

int result = FindFragment(myArray, A, B);
Console.Write($"Number of elements on diapasone from {A} to {B} is {result}");