double Power (int A, int B)
{
    double result = Math.Pow (A, B);
    return result;
}
Console.WriteLine ("enter first integer ");
try
{
    int A = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine ("enter second integer ");
    int B = Convert.ToInt32 (Console.ReadLine());
    if (B<=0) Console.WriteLine ("please enter positive integer greater than 0 as your second number");
    else Console.WriteLine ($"Number {A} in power {B} equals {Power (A, B)}");
}
catch
{
    Console.WriteLine ("please enter integers ");
}

