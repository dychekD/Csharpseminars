int [,] FillArray (int line, int col)
{
    int [,] arr = new int [line, col];
    for (int i=0; i < line; i++)
    {
        for (int j=0; j< col; j++) arr [i,j] = new Random ().Next (-100, 101);
    }
    return arr;
}
void PrintArray (int [,] arr)
{
    for (int i=0;i<arr.GetLength (0);i++) 
    {
        for (int j = 0; j < arr.GetLength (1); j++)
            {
               if (j!= arr.GetLength (1)-1) Console.Write ($"{arr [i,j]}, ");
               else if (i==arr.GetLength (0)-1 && j==arr.GetLength (1)-1) Console.WriteLine ($"{arr [i,j]}");
               else if (j == arr.GetLength (1)-1) Console.WriteLine ($"{arr [i,j]},");
            }
    }
}
int [] Stats (int [,] arr)
{
    int [] stat = new int [6];
    stat [0]=0;
    stat [1]=0;
    stat [3]=0;
    stat [4]=0;
    for (int i = 0; i<arr.GetLength (0); i++)
    {
        for (int j=0; j<arr.GetLength (1);j++)
        {
            if (arr [i,j]>arr [stat[0],stat[1]])
            {            
                stat [0]=i;
                stat [1]=j;
            }
            else if (arr [i,j]<arr [stat[3],stat[4]])
            {            
                stat [3]=i;
                stat [4]=j;
            }
        }
    }
    stat [2] = arr [stat[0],stat[1]];
    stat [5] = arr [stat[3],stat[4]];
    Console.WriteLine ($"max number: {stat [2]}");
    Console.WriteLine ($"max number index: [{stat [0]},{stat [1]}]");
    Console.WriteLine ($"min number: {stat [5]}");
    Console.WriteLine ($"min number index: [{stat [3]},{stat [4]}]");
    return stat;
}
Console.WriteLine ("enter number of rows");
int M = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("enter number of columns");
int N = Convert.ToInt32 (Console.ReadLine ());
int [,] res = FillArray (M,N);
PrintArray (res);
int [] result = Stats (res);