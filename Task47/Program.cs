// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[] FillArrayThree(int a, int b, int c)
{
    int[] result = new int[a * b * c];
    int[] index = new int[90];
    int v = 10;
    int i = 0;
    while (i < index.Length)
    {
        index[i] = v;
        v++;
        i++;
    }
    int j = 0; // для сортировки 
    int x = 0; // нижняя граница диапазона чисел для генератора псевдослучайных
    int z = 0;
    int m = 0;
    while (z < result.Length)
    {
        m = new Random().Next(x, index.Length);
        result[z] = index[m];
        int temp = index[m];
        index[m] = index[j];
        index[j] = temp;
        x++;
        z++;
        j++;
    }
    return result;
}
int[,,] RandomDoubleDigit(int[] arr, int a, int b, int c)
{
    int[,,] result = new int[a, b, c];
    int l = 0;
    int i = 0;
    int j = 0;
    for (int z = 0; z < c; z++)
    {
        while (i < a)
        {
            while (j < b)
            {
                result[i, j, z] = arr[l];
                l++;
                j++;
            }
            i++;
            j = 0;
        }
        i = 0;
        j = 0;
    }
    return result;
}
void PrintArray3(int[,,] arr)
{
    int i = 0;
    int j = 0;
    for (int z = 0; z < arr.GetLength(2); z++)
    {
        while (i < arr.GetLength(0))
        {
            while (j < arr.GetLength(1))
            {
                if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j, z]}({i}, {j}, {z})  ");
                else if (j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j, z]}({i}, {j}, {z})  ");
                j++;
            }
            i++;
            j = 0;
        }
        i = 0;
        j = 0;
    }
}
try
{
    Console.WriteLine("enter the size of your three-dimensional array, so that the product of a*b*c is not greater than 90");
    Console.WriteLine("enter the size of first dimension a:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter the size of second dimension b:");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter the size of third dimension c:");
    int c = Convert.ToInt32(Console.ReadLine());
    if (a * b * c > 90) Console.WriteLine("enter the size of your three-dimensional array, so that the product of a*b*c is not greater than 90");
    else
    {
        int[] res = FillArrayThree(a, b, c);
        int[,,] resu = RandomDoubleDigit(res, a, b, c);
        PrintArray3(resu);
    }
}
catch
{
    Console.WriteLine("please enter integers");
}


