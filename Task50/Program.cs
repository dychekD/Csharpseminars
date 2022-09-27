// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int count = 10;
// int SumDig (int number)
// {
//     if (number % 10 == number) return number;
//     return (number % 10) + SumDig (number/10);
// }

// Console.WriteLine (SumDig (45675));

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int Power (int a, int b)
// {
//     if (b==0) return 1;
//     return a*(Power (a, b-1));
// }

// Console.WriteLine (Power (3, 4));


// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// string NumbersTo (int N)
// {
//     if (N==0) return String.Empty;
//     return $"{NumbersTo (N-1)}, {N}";
// }

// Console.WriteLine (NumbersTo (10));
// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// string NumbersToN (int m, int n)
// {
//     if (m<=n) return $"{m}, {NumbersToN (m+1, n)}";
//     return String.Empty;
// }

// Console.WriteLine (NumbersToN (3, 10));


// **Задача 68:** Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann (int m, int n)
{
    if (m==0) return n+1;
    else if (n==0 && m>0) return Ackermann (m-1,1);
    else return (Ackermann (m-1,  Ackermann (m, n-1)));
}
Console.WriteLine (Ackermann (3,2));

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NumbersTo (int N)
{
    if (N==1) return "1";
    return $"{N}, {NumbersTo (N-1)}";
}
Console.WriteLine (NumbersTo (5));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumBetween (int m, int n)
{
    if (m<=n) return m+SumBetween (m+1, n);
    else return 0;
}
Console.WriteLine (SumBetween (5, 10));
