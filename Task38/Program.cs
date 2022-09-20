// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , 
//причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей. 
//Перемешать случайным образом элементы массива, причем чтобы каждый гарантированно переместился на другое место 
//(возможно для этого удобно будет использование множества) и выполнить это за m*n / 2 итераций. 
//То есть если массив три на четыре, то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран как таблицу.
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
void PrintArray1(int [] mmm)
            {
                       for (int i=0;i<mmm.Length;i++) 
                {
                    if (i!=mmm.Length-1) Console.Write($"{mmm[i]}; ");
                    else Console.WriteLine($"{mmm[i]}");
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
int [] RandomOneLine (int [] array)
{
    int [] index = new int [array.Length];
    for (int i=0; i< index.Length; i++) index [i]=i;
    int j = 0; // для сортировки пузырьком 1
    int l = 1; // для сортировки пузырьком 2
    int x = 0; // нижняя граница диапазона чисел для генератора псевдослучайных
    int z = 0; 
    int m = 0;
    while (z <= index.Length / 2)
    {
        if (x<index.Length-2)
        {
        m = new Random().Next(x, index.Length);
        int temp = index [m];
        index [m] = index[j];
        index[j] = temp;
        x++;
        m = new Random().Next(x, index.Length);
        temp = index [m];
        index [m] = index[l];
        index[l] = temp;
        
        int temp1 = array[index[j]];
        array[index[j]] = array[index[l]];
        array[index[l]] = temp1;
        }
        else if (x==index.Length-2)
        {
            int temp2 = array[index[j]];
            array[index[j]] = array[index[l]];
            array[index[l]] = temp2;
        }
        z++;
        x++;
        j = j + 2;
        l = l + 2;
        
    }
    return array;
}
int [,] RandomMatr (int [] mass, int line, int col)
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
Console.WriteLine ("enter even number of rows");
int M = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("enter even number of columns");
int N = Convert.ToInt32 (Console.ReadLine ());
int [,] res = FillArray (M,N);
PrintArray (res);
Console.WriteLine ();
int [] line = OneLine (res);
PrintArray1 (line);
PrintArray1 (RandomOneLine (line));
Console.WriteLine ();
PrintArray (RandomMatr (line, M, N));
