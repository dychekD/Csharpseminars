int SummOfDigits (int N)
{
    int result = 0;
    while (N > 0)
        {
            result = result + N % 10;
            N = N / 10;
        }
    return result;
}
Console.WriteLine ("enter positive integer ");
try
{
    int N = Convert.ToInt32 (Console.ReadLine());
    if (N<=0) Console.WriteLine ("please enter positive integer ");
    else Console.WriteLine ($"Sum of all digits in number {N} equals {SummOfDigits (N)}");
}
catch
{
    Console.WriteLine ("please enter integers ");
}