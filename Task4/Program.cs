Console.WriteLine ("enter positive integer greater than 1 ");
try
{
    int a = Convert.ToInt32(Console.ReadLine());
    int even = 2;
    while (even <= a) 
    {
        Console.Write (even+ ", ");
        even = even + 2;
    }
}
catch
{
    Console.WriteLine ("Please enter positive integer greater than 1");
}
