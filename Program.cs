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