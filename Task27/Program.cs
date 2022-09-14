int[] FillArray(int size)
            {
            int[] mas = new int[size];

            for (int i=0;i<size;i++) 
                {
                    mas[i]= new Random().Next(100,1000);
                }
            return mas;
            }
            
void PrintArray(int[] mmm)
            {
                       for (int i=0;i<mmm.Length;i++) 
                {
                    if (i!=mmm.Length-1) Console.Write($"{mmm[i]}, ");
                    else Console.WriteLine($"{mmm[i]}");
                }
            }
int PosNum (int [] numbers)
{
    int result = 0;
    foreach (var item in numbers)
        if (item % 2 == 0) result++;
    return result;
}
Console.WriteLine ("enter the size of your array");
try
{
    int L = Convert.ToInt32 (Console.ReadLine ());
    int [] Pos = FillArray (L);
    PrintArray (Pos);
    Console.WriteLine ($"the number of positive integers in this array equals {PosNum (Pos)}");
}
catch
{
    Console.WriteLine ("enter a positive integer");
}