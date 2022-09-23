// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
int RowMinSum(int[,] arr)
{
    int result = 0;
    int[] sums = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++) sums[i] = sums[i] + arr[i, j];
        }
    for (int i = 0; i < arr.GetLength(0); i++)
        {
            if (sums [i] < sums [result]) result = i;
        }
    result = result +1;
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
    Console.WriteLine ();
    Console.WriteLine ($"row with the minimal sum of elements - {RowMinSum (res)}");
}
catch
{
    Console.WriteLine("please enter integers");
}