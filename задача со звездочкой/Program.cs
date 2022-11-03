// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]


int[] NewArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void Sort(int[] arr)
{
    int emp = 0;
    for(int i = 0; i < arr.Length - 1; i++)
    {
         for(int a = i + 1; a < arr.Length; a++)
         {
            if(arr[i] < arr[a])
            {
                emp = arr[i];
                arr[i] = arr[a];
                arr[a] = emp;
            }
         }
    }
}

Console.WriteLine("Введите размер массива: ");
int num = int.Parse(Console.ReadLine()!);

int[] arr = NewArray (num, -10, 10);
Console.WriteLine(String.Join(", ", arr));
Sort(arr);
Console.WriteLine(String.Join(", ", arr));