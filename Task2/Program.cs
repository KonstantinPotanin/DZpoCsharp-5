// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] InitArray ()
{
    int [] result = new int [4];
    Random rnd = new Random ();

    for (int i = 0; i < result.Length; i++)
    {
        result [i] = rnd.Next(-10, 11);
    }
    return result;
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array [i]} ");
    }
    Console.WriteLine();
}

int SumOddIndexArray (int [] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr [i];
    }
    return sum;
}

int [] array = InitArray();
PrintArray(array);
int sumOddInd = SumOddIndexArray(array);
Console.WriteLine($"Сумма нечетных индексов в масиве равна {sumOddInd}");