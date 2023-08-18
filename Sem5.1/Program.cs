// Функция создания массива
int[] GetArray(int size, int firstnumber, int secondnumber)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(firstnumber, secondnumber);
    }
    return result;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите начальное число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конечное число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

int[] array = GetArray(size, firstnumber, secondnumber);
Console.WriteLine($"[{string.Join(", ", array)}]");

int resultCount (int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) count ++;
    }
    return count;
}

int count = resultCount(array);

Console.WriteLine($"Колличество четных элементов в массиве [{string.Join(", ", array)}] равно: {count}");
