// Задача HARD SORT.
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10
int [,] FillArray (int line, int col)
{
    int [,] arr = new int [line, col];
    for (int i=0; i < line; i++)
    {
        for (int j=0; j< col; j++) arr [i,j] = new Random ().Next (0, 100);
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
int [] OneLine (int [,] arr)
{
    int [] result = new int [arr.GetLength (0)* arr.GetLength (1)];
    int l =0;
    for (int i=0;i<arr.GetLength (0);i++) 
    {
        for (int j = 0; j < arr.GetLength (1); j++) 
        {
            result [l] = arr [i,j];
            l++;
        }
    }
    return result;
}
int [] SortedOneLine (int [] oneLine)
{
    for (int i=0;i<oneLine.Length -1;i++) 
    {
        for (int j = i+1; j < oneLine.Length; j++) 
        {
            if (oneLine [i] > oneLine[j])
            {
                int temp = oneLine [i];
                oneLine [i] = oneLine[j];
                oneLine [j] = temp;
            }
        }
    }
    return oneLine;
}
int [,] SortedMatr (int [] mass, int line, int col)
{
    int [,] result = new int [line,col];
    int l = 0;
    for (int i=0;i<line; i++) 
    {
        for (int j = 0; j < col; j++) 
        {
            result [i, j] = mass [l];
            l++;
        }
    }
    return result;
}
try
{
    Console.WriteLine("enter number of rows");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter number of columns");
    int n = Convert.ToInt32(Console.ReadLine());
    int [,] res = FillArray(m, n);
    PrintArray(res);
    int [] res1 = SortedOneLine (OneLine (res));
    int [,] sres = SortedMatr (res1, m, n);
    Console.WriteLine ();
    PrintArray (sres);
}
catch
{
    Console.WriteLine("please enter integers");
}
