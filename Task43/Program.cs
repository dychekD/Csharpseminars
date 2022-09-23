// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// int [,] FillArray (int line, int col)
// {
//     int [,] arr = new int [line, col];
//     for (int i=0; i < line; i++)
//     {
//         for (int j=0; j< col; j++) arr [i,j] = new Random ().Next (0, 100);
//     }
//     return arr;
// }
// void PrintArray (int [,] arr)
// {
//     for (int i=0;i<arr.GetLength (0);i++) 
//     {
//         for (int j = 0; j < arr.GetLength (1); j++)
//             {
//                if (j!= arr.GetLength (1)-1) Console.Write ($"{arr [i,j]}, ");
//                else if (i==arr.GetLength (0)-1 && j==arr.GetLength (1)-1) Console.WriteLine ($"{arr [i,j]}");
//                else if (j == arr.GetLength (1)-1) Console.WriteLine ($"{arr [i,j]},");
//             }
//     }
// }
// int [,] FirstChangeLast (int [,] array)
// {
//     for (int i = 0; i < array.GetLength (1); i++)
//     {
//         // int temporary = array [0,i];
//         // array [0, i] = array [array.GetLength (0) -1 , i];
//         // array [array.GetLength (0) -1 , i] = temporary;
//         (array [0, i] , array [array.GetLength (0) -1 , i]) = (array [array.GetLength (0) -1 , i], array [0, i]);
//     }
//     return array;
// }

// Console.WriteLine ("enter number of rows");
// int m = Convert.ToInt32 (Console.ReadLine ());
// Console.WriteLine ("enter number of columns");
// int n = Convert.ToInt32 (Console.ReadLine ());
// int [,] res = FillArray (m,n);
// PrintArray (res);
// Console.WriteLine ();
// res = FirstChangeLast (res);
// PrintArray (res);



// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// int [,] FillArray (int line, int col)
// {
//     int [,] arr = new int [line, col];
//     for (int i=0; i < line; i++)
//     {
//         for (int j=0; j< col; j++) arr [i,j] = new Random ().Next (0, 100);
//     }
//     return arr;
// }
// void PrintArray (int [,] arr)
// {
//     for (int i=0;i<arr.GetLength (0);i++) 
//     {
//         for (int j = 0; j < arr.GetLength (1); j++)
//             {
//                if (j!= arr.GetLength (1)-1) Console.Write ($"{arr [i,j]}, ");
//                else if (i==arr.GetLength (0)-1 && j==arr.GetLength (1)-1) Console.WriteLine ($"{arr [i,j]}");
//                else if (j == arr.GetLength (1)-1) Console.WriteLine ($"{arr [i,j]},");
//             }
//     }
// }
// int [,] ChangeColRow (int [,] arr)
// {
//     if (arr.GetLength (0) != arr.GetLength (1)) Console.WriteLine ("cannot change rows and columns");
//     else 
//     {
//         for (int i = 0; i < arr.GetLength (0); i++)
//         {
//             for (int j = i+1; j < arr.GetLength (1); j++) (arr [i, j] , arr [j, i]) = (arr [j, i] , arr [i, j]);

//         }
//     }
//     return arr;
// }
// Console.WriteLine("enter number of rows");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter number of columns");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] res = FillArray(m, n);
// PrintArray(res);
// Console.WriteLine();
// res = ChangeColRow (res);
// PrintArray(res);


// Для двумерного массива создайте библиотеку частотности элементов массива:
// 8, 7, 7, 1, 2,
// 6, 9, 6, 6, 7,
// 8, 9, 7, 5, 9

// 1 appears 2 times in this array;
// 2 appears 2 times in this array;
// 4 appears 1 times in this array;
// 5 appears 1 times in this array;
// 6 appears 3 times in this array;
// 7 appears 4 times in this array;
// 8 appears 4 times in this array;
// 9 appears 3 times in this array;

// int[,] FillArray(int line, int col)
// {
//     int[,] arr = new int[line, col];
//     for (int i = 0; i < line; i++)
//     {
//         for (int j = 0; j < col; j++) arr[i, j] = new Random().Next(0, 10);
//     }
//     return arr;
// }
// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j]}, ");
//             else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]}");
//             else if (j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]},");
//         }
//     }
// }
// void PrintArray1(int[] mmm)
// {
//     for (int i = 0; i < mmm.Length; i++)
//     {
//         if (mmm[i] != 0) Console.WriteLine ($"{i} appears {mmm[i]} times in this array; ");
//     }
// }
// int[] Count(int[,] arr)
// {
//     int[] result = new int[10];
//     int l = 0;
//     while (l < 10)
//     {
//         for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 if (l == arr[i, j]) result[l] = result[l] + 1;
//             }

//         }
//         l++;
//     }
//     return result;
// }

// Console.WriteLine("enter number of rows");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter number of columns");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] res = FillArray(m, n);
// PrintArray(res);
// Console.WriteLine();
// int[] count = Count(res);
// PrintArray1(count);

// В двумерном массиве найдите минимальное значение и удалите строку и столбец с ним.
// Например
// 61, 71, 79, 59,
// 27, 51, 6, 39,
// 26, 72, 84, 97,
// 29, 74, 23, 66

// 61, 71, 59,
// 26, 72, 97,
// 29, 74, 66

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
int [,] ReducedArray (int [,] arr)
{
    int [,] reduced = new int [arr.GetLength (0) - 1, arr.GetLength (1) - 1];
    int m1 = 0;
    int m2 = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr [i,j]< arr [m1, m2])
            {
                m1 = i;
                m2 = j;
            }
        }
    }
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < reduced.GetLength (1); j++)
            {
                if (j < m2) reduced [i,j] = arr [i,j];
                else reduced [i,j] = arr [i,j+1];
            }
    }
    for (int i = m1; i < reduced.GetLength (0); i++)
    {
        for  (int j = 0; j < reduced.GetLength (1); j++)
            {
                if (j < m2) reduced [i,j] = arr [i+1,j];
                else reduced [i,j] = arr [i+1,j+1];
            }
    }
    return reduced;
}

Console.WriteLine ("enter number of rows");
int M = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("enter number of columns");
int N = Convert.ToInt32 (Console.ReadLine ());
int [,] res = FillArray (M,N);
PrintArray (res);
Console.WriteLine ();
int [,] red = ReducedArray (res);
PrintArray (red);