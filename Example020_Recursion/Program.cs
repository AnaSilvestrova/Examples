/* Вычисление факториала. Рекурсия.
 5! = 5 * 4 * 3 * 2 * 1
    5 * 4!
        4 * 3!
            3 * 2!
*/         

/*
int Factorial(int n)
{
 // 1! = 1
 // 0! = 1
 if(n == 1) return 1;
 else return n * Factorial(n-1);
}
Console.WriteLine(Factorial(5)); // 1 * 2 * 3 = 6; 5! = 120
*/
Console.Clear();

double Factorial(int n)
{
 // 1! = 1
 // 0! = 1
 if(n == 1) return 1;
 else return n * Factorial(n-1);
}
for (int i = 0; i < 40; i++)
{
    Console.WriteLine($"{i!} = {Factorial(i)}");
}
