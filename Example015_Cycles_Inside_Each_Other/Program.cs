/* Цикл внутри цикла.
Example:
for(int i = 0; i < 10; i++)
{
    for(int j = 0; j < 10; j++)
    {
        Console.WriteLine(i*j);
    }
    Console.WriteLine();
}
Задача: вывод на экран таблицы умножения.
*/
for (int i = 2; i <= 10; i++) // Внешний цикл.
{
    for (int j = 2; j <= 10; j++) // Внутренний цикл.
    {
        Console.WriteLine($"{i} * {j} = {i*j}"); // Интерполяция строк.
    }
    Console.WriteLine(); // Переход на новую строку для каждой десятки.
}