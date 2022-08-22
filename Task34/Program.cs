/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

using static System.Console;
Clear();

int[] array = new int[4];

newArray(array);
WriteLine($"[{String.Join(",", array)}]");
WriteLine($"Количество чётных чисел в массиве = {someCount(array)}");
WriteLine();


void newArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}


int someCount(int[] array)
{
    int counter = 0;
    foreach (int i in array)
        if (i % 2 == 0) counter++;
    return counter;
}