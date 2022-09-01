Console.WriteLine ("enter integer ");
try
{
    int a = Convert.ToInt32(Console.ReadLine());
    if (a%2 == 0) 
    {
        Console.WriteLine (a+" - even number");
    }
    else 
    {
        Console.WriteLine (a+" - odd number");
    }
}
catch
{
    Console.WriteLine ("Please enter integer");
}