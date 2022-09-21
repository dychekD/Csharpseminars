// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
double[] ArithEven(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    int l = 0;
    result[l] = 0;
    int j = 0;
    while (j < array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result[l] = result[l] + array[i, j];
        }
        j++;
        l++;
    }
    for (int m = 0; m < result.Length; m++) result[m] = Math.Round((Convert.ToDouble(result[m]) / Convert.ToDouble(array.GetLength(0))), 2);
    return result;
}
void PrintArray1(double[] mmm)
{
    for (int i = 0; i < mmm.Length; i++)
    {
        if (i != mmm.Length - 1) Console.Write($"{mmm[i]}; ");
        else Console.WriteLine($"{mmm[i]}");
    }
}
try
{
    Console.WriteLine("enter number of rows");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter number of columns");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] res = FillArray(m, n);
    PrintArray(res);
    double[] res1 = ArithEven(res);
    Console.Write("arithmetical even of each column equals: ");
    PrintArray1(res1);
}
catch
{
    Console.WriteLine("please enter integers");
}
