//общий блок из 2-х методов

double[] createRandArrayIntDouble(int size, int min, int max, bool a) //true - целые, false - вещественные
{
    double[] array = new double[size];
    if (a == true)
    {
        for (int i = 0; i < size; i++)
            array[i] = new Random().Next(min, max + 1);
    }
    if (a == false)
    {
        for (int i = 0; i < size; i++)
            array[i] = new Random().Next(min, max + 1) + new Random().NextDouble();
    }
    return array;
}

void showArray(double[] array2)
{
    for (int i = 0; i < array2.Length; i++)
        Console.Write(array2[i] + " ");

    Console.WriteLine();
}

/* 
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void even(int[] array3)
{
    int count = 0;
    for (int i = 0; i < array3.Length; i++)
        if (array3[i] % 2 == 0) count++;
    Console.WriteLine("Количество чётных чисел в массиве: " + count);
}

int[] myArray = createRandArrayIntDouble(10, 100, 1000, true);
showArray(myArray);
even(myArray);




/* 
Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void SumUnevenPos(int[] array4)
{
    int count = 0;
    for (int i = 0; i < array4.Length; i++)
        if (i % 2 == 0) count = count + array4[i];
    Console.WriteLine(count);
}

int[] myArray = createRandArrayIntDouble(5, 1, 10, true);
showArray(myArray);
SumUnevenPos(myArray);




/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void VeshMinMax(double[] array5)
{
    double max = array5[0];
    double min = array5[0];
    for (int i = 0; i < array5.Length; i++)
    {
        if (max < array5[i]) max = array5[i];
        if (min > array5[i]) min = array5[i];
    }
    double a = max-min;
    Console.WriteLine("Разница: " + a);
}

double[] myArray = createRandArrayIntDouble(5, 1, 10, false);
showArray(myArray);
VeshMinMax(myArray);
