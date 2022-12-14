// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] NewArray(int size) 
{
    int[] result = new int[size];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

int ElementNum(int[] array)
{
    int elm = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if((array[i] % 2) == 0)
        {
            elm++;
        }
    }
    return elm;
}

Console.WriteLine("Введите размер массива:");
int n = int.Parse(Console.ReadLine()!);
int[] array = NewArray(n);
ElementNum(array);
Console.WriteLine($"Колличество четных = {ElementNum(array)}");
Console.WriteLine(String.Join(", ", array));

