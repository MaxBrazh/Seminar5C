﻿/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

using static System.Console;
Clear();

int[] array = new int[4];
newArray(array);
WriteLine($"[{String.Join(",", array)}]");
WriteLine($"Сумма элементов, стоящих на нечётных позициях массива = {minusSum(array)}");
WriteLine();


void newArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 99);
    }
}


int minusSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}