// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] GenerateArray(int Length)
{
    double [] array = new double[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble (new Random().Next(0, 100)) / 10;
    }   
    return array;
}

void PrintArray(double[] array)
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

double minmax (double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            {
                max = array[i];
            }
        if (array[i] < min)
            {
                min = array[i];
            }
    }
    return max - min;
}

int Length = Promt("Введите длину массива");
double[] array = GenerateArray(Length);
PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {minmax(array)}  ");
