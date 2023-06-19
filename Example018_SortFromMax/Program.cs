/*
Упорядочивание данных массива: сортировка методом выбора: от максимального к минимальному.
*/

int[] arr = {8, 5, 4, 9, 10, 1, 3, 6, 7};

void PrintArray(int[] array) // Метод для печати массива.
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // Метод для упорядочивания массива.
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j; // Внутренний цикл для нахождения минимума. 
        }
        
        int temporary = array[i];
        array[i] = array[maxPosition]; 
        array[maxPosition] = temporary; // Обмен двух переменных местами.
    }
}

PrintArray(arr); // Вызываем метод, печатаем массив.
SelectionSort(arr); // Делаем сортировку.
PrintArray(arr); // Печатаем упорядоченный массив.