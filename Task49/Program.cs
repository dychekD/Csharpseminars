// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int [,] Snail (int [] array, int size)
{
    int [,] result = new int [size, size];
    int l = 0;
    int i = 0;
    int j = 0;
    int m = 0;
    while (l < array.Length)
    {
        i = 0 + m;
        while (j <= result.GetLength(1) - 1 - m)
        {
            result[i, j] = array[l];
            j++;
            l++;
        }
        j = result.GetLength(1) - 1 - m;
        i++;
        while (i <= result.GetLength(0) - 1 - m)
        {
            result[i, j] = array[l];
            i++;
            l++;
        }
        i = result.GetLength(0) - 1 - m;
        j = j - 1;
        while (j >= 0 + m)
        {
            result[i, j] = array[l];
            j = j - 1;
            l++;
        }
        i = i - 1;
        j = 0 + m;
        m++;
        while (i >= 0 + m)
        {
            result[i, j] = array[l];
            i = i - 1;
            l++;
        }
        j++;
    }
    return result;
}
int [] OneLine (int size)
{
    int [] result = new int [size*size];
    for (int i=0; i< result.Length; i++) result [i] = i+1;
    return result;
}
void PrintArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr [i,j] < 10 && j!=arr.GetLength(1) - 1) Console.Write ($"0{arr [i,j]} ");
            else if (arr [i,j] < 10 && j==arr.GetLength(1) - 1) Console.WriteLine ($"0{arr [i,j]}");
            else if (arr [i,j] >= 10 && j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j]} ");
            else if (arr [i,j] >= 10 && j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]} ");
        }
    }
}
try
{
    Console.WriteLine("enter size of your square array");
    int size = Convert.ToInt32(Console.ReadLine());
    int [] line = OneLine (size);
    int [,] res = Snail (line, size);
    PrintArray (res);
}
catch
{
    Console.WriteLine("please enter integers");
}

