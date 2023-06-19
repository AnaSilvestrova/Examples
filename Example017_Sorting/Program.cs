/*
Упорядочивание данных массива: сортировка методом выбора.
*/

int[] arr = {6, 5, 3, 7, 4, 9, 2, 1, 0};

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
    for(int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j; // Внутренний цикл для нахождения минимума. 
        }
        
        int temporary = array[i];
        array[i] = array[minPosition]; 
        array[minPosition] = temporary; // Обмен двух переменных местами.
    }
}

PrintArray(arr); // Вызываем метод, печатаем массив.
SelectionSort(arr); // Делаем сортировку.
PrintArray(arr); // Печатаем упорядоченный массив.