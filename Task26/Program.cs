// int[] FillArray(int size)
//             {
//             int[] mas = new int[size];

//             for (int i=0;i<size;i++) 
//                 {
//                     mas[i]= new Random().Next(-9,10);
//                 }
//             return mas;
//             }
            
//         void PrintArray(int[] mmm)
//             {
           
//             for (int i=0;i<mmm.Length;i++) 
//                 {
//                     if (i!=mmm.Length-1) Console.Write($"{mmm[i]}, ");
//                     else Console.WriteLine($"{mmm[i]}");
//                 }

//             }
// int[] FindSums(int[] mmm)
//             {
//             int[] sums=new int[2];
//             foreach (int item in mmm)
//                 {
//                     if (item>0) sums[1]+=item;
//                     else sums[0]+=item;
//                 }
//             return sums;
//             }

//         int[] array=FillArray(12);
//         PrintArray(array);
//         int[] results = FindSums(array);
//         Console.WriteLine($"Сумма положительныъ элементов массива равна {results[1]}");
//         Console.WriteLine($"Сумма отрицательных элементов массива равна {results[0]}");


// int[] FillArray(int size)
// {
//     int[] mas = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         mas[i] = new Random().Next(-9, 10);
//     }
//     return mas;
// }

// int[] changeArray(int[] mas)
// {
//     for (int i = 0; i < mas.Length; i++)
//     {
//         mas[i] *= -1;
//     }
//     return mas;
// }

// void PrintArray(int[] mmm)
// {

//     for (int i = 0; i < mmm.Length; i++)
//     {
//         if (i != mmm.Length - 1) Console.Write($"{mmm[i]}, ");
//         else Console.WriteLine($"{mmm[i]}");
//     }

// }

// try
// {
//     int[] array = FillArray(12);
//     PrintArray(array);
//     PrintArray(changeArray(array));
// }
// catch
// {
//     Console.WriteLine("Что-то пошло не так!");
// }


// int[] arr = FillArray(15);

// string FindDigit(int[] array, int findNum){
//     // int[] result = new int[array.Length];
//     string result = String.Empty;
//     for (int i = 0; i < array.Length; i++){
//         if (array[i] == findNum) {
//             result = "Да";
//              break;
//         } else result = "нет";
//     }
//     return result;
// }
// PrintArray(arr);
// Console.WriteLine(FindDigit(arr, 5));


// int[] FillArray(int size)
//             {
//             int[] mas = new int[size];

//             for (int i=0;i<size;i++) 
//                 {
//                     mas[i]= new Random().Next(-100,100);
//                 }
//             return mas;
//             }
// void PrintArray(int[] mmm)
//             {
           
//             for (int i=0;i<mmm.Length;i++) 
//                 {
//                     if (i!=mmm.Length-1) Console.Write($"{mmm[i]}, ");
//                     else Console.WriteLine($"{mmm[i]}");
//                 }

//             }

// int[] arr = FillArray(15);

// PrintArray(arr);
// int count = 0;

// for(int i = 0; i < arr.Length; i++)
// {
//     if(arr[i]> 10 && arr[i] < 100)
//     count++;
// }
// Console.WriteLine($"В массиве {count} элементов лежит в отрезке от 10 до 99");

int[] FillArrayTen(int size)
{
    int[] mas = new int[size];

    for (int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next(-10, 11);
    }
    return mas;
}
int[] pair(int[] mas)
{
    int L = Convert.ToInt32(Math.Round(Convert.ToDouble(mas.Length / 2)));

    int[] result = new int[L+1];
    for (int i = 0; i < mas.Length / 2; i++)
    {

        result[i] = mas[i] * mas[mas.Length - 1 - i];

    }
    result[L] = mas[L];
    return result;
}
System.Console.WriteLine("Enter size of array");
int size = Convert.ToInt32(Console.ReadLine());
int[] inputTen = FillArrayTen(size);
System.Console.WriteLine(string.Join(",", inputTen));
System.Console.WriteLine(string.Join(",", pair(inputTen)));
