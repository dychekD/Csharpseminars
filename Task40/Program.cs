// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
void NumIndex (int [,] array, int irow, int jcol)
{
    if (irow < array.GetLength (0) && jcol < array.GetLength (1)) Console.WriteLine (array [irow, jcol]);
    else Console.WriteLine ("no element in this array with such indexes");
}
try
{
    Console.WriteLine("enter number of rows");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter number of columns");
    int n = Convert.ToInt32(Console.ReadLine());
    int [,] res = FillArray(m, n);
    PrintArray(res);
    Console.WriteLine("enter row of the element you are looking for");
    int k = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter column of the element you are looking for");
    int l = Convert.ToInt32(Console.ReadLine());
    NumIndex (res, k, l);
}
catch
{
    Console.WriteLine("please enter integers");
}