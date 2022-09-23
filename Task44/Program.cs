// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] FillArray(int line, int col)
{
    int[,] arr = new int[line, col];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < col; j++) arr[i, j] = new Random().Next(0, 100);
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
int [,] SortRows (int [,] arr)
{
    int i = 0;
    while (i < arr.GetLength (0))
        {
            for (int j = 0; j <arr.GetLength (1) - 1; j++)
            {
                for (int l = j+1; l < arr.GetLength (1); l++)
                {
                    if (arr [i, l] > arr [i, j]) (arr [i, j], arr [i, l]) = (arr [i, l], arr [i, j]);
                }
            }
            i++;
        }
    return arr;
}

try
{
    Console.WriteLine("enter number of rows");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter number of columns");
    int n = Convert.ToInt32(Console.ReadLine());
    int [,] res = FillArray(m, n);
    PrintArray(res);
    Console.WriteLine ();
    res = SortRows (res);
    PrintArray (res);
}
catch
{
    Console.WriteLine("please enter integers");
}