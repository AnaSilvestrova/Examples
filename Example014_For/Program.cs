/* Цикл for, или цикл со счетчиком.
Example:
for (int i = 0; i < 10; i++)
{
    Console.WriteLine();
}
*/

string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++) // Инициализация счетчика, проверка условия, инкремент. 
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z"); // В "" текст, который будет "склеиваться" 10 раз.
Console.WriteLine(res);