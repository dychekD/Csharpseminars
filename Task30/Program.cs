int [] FillArray(int size)
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
double [] Stats (int [] numbers)
{
    double [] result = new double [6];
    int Imax = 0;
    int Imin = 0;
    for (int i=0; i<numbers.Length; i++) 
    {
        result [4]+=numbers[i];
        if (numbers [i] < numbers [Imin]) Imin = i;
        else if (numbers [i] > numbers [Imax]) Imax = i;
    }
    result [0] = numbers [Imax];
    result [1] = Imax;
    result [2] = numbers [Imin];
    result [3] = Imin;
    result [4] = result[4] / numbers.Length;
    int [] arr = numbers;
    for (int j = 0; j < arr.Length-1; j++)
        {
            for (int g = j +1 ; g < arr.Length; g++)
        {
            if (arr [j] > arr [g]) 
        {
            int temp = arr [j];
            arr [j] = arr [g];
            arr [g] = temp;
        }
        }
        }
    for (int o = 0; o < arr.Length; o++) Console.Write ($"{arr [o]}, ");
    if (arr.Length % 2 == 0) result [5] = (Convert.ToDouble (arr [arr.Length /2 -1] + arr [arr.Length /2]))/ 2;
    else result [5] = arr [arr.Length /2];
    Console.WriteLine ($"max number in array: {result [0]}");
    Console.WriteLine ($"index of max number in array: {result [1]}");
    Console.WriteLine ($"min number in array: {result [2]}");
    Console.WriteLine ($"index of min number in array: {result [3]}");
    Console.WriteLine ($"arithmetic mean of array: {result [4]}");
    Console.WriteLine ($"median of array: {result [5]}");
    return result;
}
Console.WriteLine ("enter the size of your array");
try
{
    int L = Convert.ToInt32 (Console.ReadLine ());
    int [] AnyArr = FillArray (L);
    PrintArray (AnyArr);
    Stats(AnyArr);
}
catch
{
    Console.WriteLine ("enter a positive integer");
}