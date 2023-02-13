// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] InitArray ()
{
    double [] result = new double [5];
    Random rnd = new Random ();

    for (int i = 0; i < result.Length; i++)
    {
        result [i] = Convert.ToDouble(new Random().Next(100,1000)) / 10;
    }
    return result;
}

 void PrintArray(double[] array)
 {
     for (int i = 0; i < array.Length; i++)
     {
         Console.Write ($"{array [i]} ");
     }
     
 }

 double GetMaxNumber (double [] arr)
 {
    double max = arr [0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
 }

 double GetMinNumber (double [] arr)
 {
    double min = arr [0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
 }

 void GetDifferenceMaxAndMmin (double max, double min)
 {
    double difference = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элеметами равна {difference}");
 }

double [] array = InitArray();
PrintArray(array);
Console.WriteLine();
double max = GetMaxNumber(array);
double min = GetMinNumber(array);
GetDifferenceMaxAndMmin(max, min);