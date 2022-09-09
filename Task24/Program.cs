int [] Array (int N)
{
    int [] Array = new int [N];
    return Array;
} 
Console.WriteLine ("enter a positive integer ");
try
{
    int N = Convert.ToInt32 (Console.ReadLine());
    if (N<=0) Console.WriteLine ("please enter a positive integer ");
    else 
    {
        int [] arr = Array (N);
        for (int i = 0; i < N; i++)
            {
                Console.Write ("Please enter an element of the array ");
                arr [i] = Convert.ToInt32 (Console.ReadLine());
            }
        for (int i = 0; i < N-1; i++) Console.Write ($"{arr [i]}, ");
        Console.WriteLine (arr [N-1]);
    }
}
catch
{
    Console.WriteLine ("please enter integers ");
}