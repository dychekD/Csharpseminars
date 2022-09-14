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
int MaxMinDif (int [] numbers)
{
    int result = 0;
    int max = numbers [0];
    int min = numbers [0];
    for (int i=0; i<numbers.Length; i++) 
        if (numbers [i] < min) min = numbers [i];
        else if (numbers [i] > max) max = numbers [i];
    result = max - min;
    Console.WriteLine ($"max number in array: {max}");
    Console.WriteLine ($"min number in array: {min}");
    return result;
}
Console.WriteLine ("enter the size of your array");
try
{
    int L = Convert.ToInt32 (Console.ReadLine ());
    int [] AnyArr = FillArray (L);
    PrintArray (AnyArr);
    Console.WriteLine ($"the difference between max number and min number equals {MaxMinDif(AnyArr)}");
}
catch
{
    Console.WriteLine ("enter a positive integer");
}