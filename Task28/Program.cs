int[] FillArray(int size)
            {
            int[] mas = new int[size];

            for (int i=0;i<size;i++) 
                {
                    mas[i]= new Random().Next(-100,101);
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
int SumOddIndex (int [] numbers)
{
    int result = 0;
    for (int i=1; i<numbers.Length; i=i+2) result+=numbers [i];
    return result;
}
Console.WriteLine ("enter the size of your array");
try
{
    int L = Convert.ToInt32 (Console.ReadLine ());
    int [] AnyArr = FillArray (L);
    PrintArray (AnyArr);
    Console.WriteLine ($"the sum of integers with odd indexes equals {SumOddIndex (AnyArr)}");
}
catch
{
    Console.WriteLine ("enter a positive integer");
}