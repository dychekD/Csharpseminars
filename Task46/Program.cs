// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillArray(int line, int col)
{
    int[,] arr = new int[line, col];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < col; j++) arr[i, j] = new Random().Next(0, 10);
    }
    return arr;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j]}, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]}");
            else if (j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]},");
        }
    }
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
int[] ProductMatr(int[,] arrA, int[,] arrB)
{
    int[] result = new int [arrA.GetLength(0)*arrB.GetLength(1)];
    int i = 0;
    int l = 0;
    int j = 0;
    while (i < arrA.GetLength (0))
        {
            while (j < arrB.GetLength (1) && l < result.Length)
            {
                for (int m = 0; m < arrA.GetLength (1); m++)
                {
                    result [l] = result [l] + (arrA [i,m]* arrB [m,j]);
                }
                l++;
                j++;
            }
            j = 0;
            i++;
        }
    return result;
}
try
{
    Console.WriteLine("enter number of rows of the first matrix");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter number of columns of the first matrix");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter number of rows of the second matrix");
    int k = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter number of columns of the second matrix");
    int z = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ();
    int [,] mat1 = FillArray(m, n);
    PrintArray(mat1);
    Console.WriteLine ();
    int [,] mat2 = FillArray(k, z);
    PrintArray(mat2);
    Console.WriteLine ();
    if (n != k) Console.WriteLine("cannot multiply matrixes of such size");
    else 
    {
        int [] res = ProductMatr (mat1, mat2);
        PrintArray (SortedMatr (res, m, z));
    }
}
catch
{
    Console.WriteLine("please enter integers");
}
