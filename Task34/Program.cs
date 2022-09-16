string Intersection (decimal k1, decimal k2, decimal b1, decimal b2)
{
    string result = string.Empty;
    if (k1 == k2 && b1 == b2) result = "your lines overlay";
    else if (k1==k2) result = "your lines are parallel and won't intersect";
    else 
    {
        decimal x = -((b1 + (-b2)) / (k1 + (-k2)));
        decimal y = k1*x + b1;
        result = ($"lines intersect at a point ({x};{y})");
    }
    return result;
}
try
{
Console.WriteLine ("There are two lines defined by functions y=k1*x+b1 and y=k2*x+b2");
Console.WriteLine ("enter value of k1");
decimal k1 = Convert.ToDecimal (Console.ReadLine ());
Console.WriteLine ("enter value of b1");
decimal b1 = Convert.ToDecimal (Console.ReadLine ());
Console.WriteLine ("enter value of k2");
decimal k2 = Convert.ToDecimal (Console.ReadLine ());
Console.WriteLine ("enter value of b2");
decimal b2 = Convert.ToDecimal (Console.ReadLine ());
Console.WriteLine (Intersection (k1, k2, b1, b2));
}
catch
{
    Console.WriteLine ("Please enter numbers}");
}