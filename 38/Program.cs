// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] NewArray(int size, int minValue, int maxValue) 
{
    double[] array = new double[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

double MaxElement(double[] array)
{
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double MinElement(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

Console.WriteLine("Введите размер массива: ");
int num = int.Parse(Console.ReadLine()!);

double[] arr = NewArray (num, 1, 100);

double max1 = MaxElement(arr);
double min1 = MinElement(arr);
Console.WriteLine($"Разница между минимальным и максимальным значением = {max1 - min1}");
Console.WriteLine(String.Join(", ", arr));