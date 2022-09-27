// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumBetween (int m, int n)
{
    if (m<=n) return m+SumBetween (m+1, n);
    else return 0;
}

try 
{
    Console.WriteLine ("enter first integer");
    int m = Convert.ToInt32 (Console.ReadLine ());
    Console.WriteLine ("enter second integer");
    int n = Convert.ToInt32 (Console.ReadLine ());
    if (m>n) Console.WriteLine (SumBetween (n, m));
    else if (m < n) Console.WriteLine (SumBetween (m, n));
    else if (m == n) Console.WriteLine (0);
}
catch
{
    Console.WriteLine ("please enter integers");
}