// Функция создания массива
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(9, 100);
    }
    return result;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(size);
Console.WriteLine($"[{string.Join(", ", array)}]");

int difference (int[] arr)
{
    int DifferenceTheNumbers = 0;
    int max = 0;
    foreach (int el in arr)
    {
        if (el > max) max = el;
    }

    int min = max;

    foreach (int el in arr)
    {
        if (el < max && el < min) min = el;
    }
    DifferenceTheNumbers = max - min;
    return DifferenceTheNumbers;
}

int DifferenceTheElements = difference(array);
Console.Write($"Разница между макисмальным и минимальным элементом массива равна: {DifferenceTheElements}");