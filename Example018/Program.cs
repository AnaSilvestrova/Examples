// Двумерные массивы.
//string[,] table = new string[2,3]; // [строки, столбцы] - таблица строк.
//int[,] matrix = new int[5, 8]; // Таблица чисел - матрица.

string[,] table = new string[2, 5]; // Индекс от нуля.
//String.Empty;
// table[0, 0] table[0, 1] table[0,2] table[0, 3] table[0,4]
// table[1,0] table[1, 1] table[1,2] table[1, 3] table[1,4]

/* table[1, 2] = "word";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/

void PrintArray(int[,] matr)
{
    

    for (int i  = 0; i < matr.GetLength(0); i++) // For rows.
    {
        for (int j = 0; j < matr.GetLength(1); j++) // For columns.
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine(); // Принудительный переход на новую строку, когда напечатаны все столбцы.
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // Заполнение матрицы случайными числами.
        }
    }
}


int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);