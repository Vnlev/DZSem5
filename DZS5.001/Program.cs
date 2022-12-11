// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int Length)
{
    int[] array = new int [Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }   
    return array;
}

void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        System.Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}

int Promt(string messege)
{
    System.Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
}
int Eventcount(int[] array)
{
    int counter = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0)
        {
            counter++;
        }
    }
    return counter;
}

int Length = Promt("Input Lenght of array");
int[] array = GenerateArray(Length);
PrintArray(array);
Console.WriteLine(Eventcount(array));
