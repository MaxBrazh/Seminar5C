/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76 */

using static System.Console;
Clear();

// float[] array = new float[5];
// newArray(array);
// WriteLine($"[{String.Join(" ", array)}]");
// WriteLine($"{diffMaxMin(array)}");


// void newArray(float[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-99, 99);
//     }
// }
// float diffMaxMin(float[] array)
// {
//     float min, max;
//     max = min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max) max = array[i];
//         if (array[i] < min) min = array[i];
//     }
//     return max - min;
// }


double[] array = new double[5];
newArray(array);
WriteLine($"[{String.Join(" ", array)}]");
WriteLine($"{diffMaxMin(array)}");


void newArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 99);
    }
}
double diffMaxMin(double[] array)
{
    double min, max;
    max = min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return max - min;
}