// Функция создания массива
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(10, 100);
    }
    return result;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(size);
Console.WriteLine($"[{string.Join(", ", array)}]");

int SumElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) sum = sum + arr[i];
    }
    return sum;
}

int sum = SumElements(array);
Console.WriteLine($"Сумма элементов на нечетных индексах равна: {sum}");