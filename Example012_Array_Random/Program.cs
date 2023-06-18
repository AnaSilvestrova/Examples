// Решение с помощью генератора случайных чисел.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // Случайное число из диапазона 1-10.
        index++;
    }
}

void PrintArray(int[] col) // Метод, который будет печатать массив.
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // Для нахождения нужного индекса.
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // На тот случай, если искомого числа в массиве нет.

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // Создан новый массив из 10 элементов.

FillArray(array); // Заполнение массива случайными числами.
array[4] = 4;
array[6] = 4;

PrintArray(array); // Печать массива в консоли.
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine($"Нужный индекс --> {pos}");
