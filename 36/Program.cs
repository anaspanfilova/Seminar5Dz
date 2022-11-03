// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] NewArray(int size, int minValue, int maxValue) 
{
    int[] result = new int[size];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}


int SumIndexNum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i +=2)
    {
        sum += array[i];
    }
    return sum;
}


Console.Clear();
Console.WriteLine("Введите размер массива:");
int num = int.Parse(Console.ReadLine()!);

int[] newArray = NewArray (num, -10, 10);
SumIndexNum(newArray);
Console.WriteLine($"Колличество четных = {SumIndexNum(newArray)}");
Console.WriteLine(String.Join(", ", newArray));