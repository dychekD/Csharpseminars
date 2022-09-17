
void PrintArray(int[] mmm)
            {
                       for (int i=0;i<mmm.Length;i++) 
                {
                    if (i!=mmm.Length-1) Console.Write($"{mmm[i]}, ");
                    else Console.WriteLine($"{mmm[i]}");
                }
            }
int CountNull (int [] arr)
{
    int result =0;
    foreach (var item in arr) 
     if (item > 0) result++;
    return result;
}

Console.WriteLine ("enter number of integers you want to check");
int size = Convert.ToInt32 (Console.ReadLine());
int [] arr = new int [size];
Console.WriteLine ("enter integers you want to check");
for (int i = 0; i < size; i++)
{
    arr [i] = Convert.ToInt32 (Console.ReadLine ());
}
PrintArray (arr);
Console.WriteLine ($"there are {CountNull (arr)} numbers greater than zero");

