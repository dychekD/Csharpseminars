Console.WriteLine ("enter first integer ");
try
{
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("enter second integer ");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a >= b) 
    {
        Console.WriteLine ("max = "+a);
    }
    else 
    {
        Console.WriteLine ("max = "+b);
    }
}
catch
{
    Console.WriteLine ("Please enter integers");
}