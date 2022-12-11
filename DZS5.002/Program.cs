// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int Length)
{
    int[] array = new int [Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
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
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int Length = Promt("Введите длину массива");
int[] array = GenerateArray(Length);
PrintArray(array);
Console.WriteLine(Eventcount(array));
