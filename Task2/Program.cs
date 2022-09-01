Console.WriteLine ("enter first integer ");
try
{
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("enter second integer ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("enter third integer ");
    int c = Convert.ToInt32(Console.ReadLine());
    int max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    Console.WriteLine ("max = "+max);
}
catch
{
    Console.WriteLine ("Please enter integers");
}
