int[] ArrayN(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++) array[i] = new Random().Next(1, 100);
    return array;
}
try
{
    Console.Write("Enter integer ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Array of {a} elements: ");
    int[] array = ArrayN(a);
    for (int i = 0; i < array.Length - 1; i++) Console.Write(array[i] + ", ");
    Console.WriteLine(array[array.Length - 1]);

}
catch (System.Exception)
{

    Console.WriteLine("Надо было вводить именно целое число!");
}

// int[] ArrayN(int N)
// {
//     int[] array = new int[N];
//     for (int i = 0; i < N; i++) array[i] = new Random().Next(1, 100);
//     return array;
// }
// int Max(int[] array)
// {
//     int max = array[0];
//     for (int i = 1; i <array.Length; i++)
//     {
//         if (max< array[i]) max=array[i];
//     }
//     return max;
// }
// try
// {
//     Console.Write("Введите целое число ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.Write($"Массив из {a} элементов: ");
//     int[] array = ArrayN(a);
//     for (int i = 0; i < array.Length - 1; i++) Console.Write(array[i] + ", ");
//     Console.WriteLine(array[array.Length - 1]);
//     Console.WriteLine($"Максимальный элемент {Max(array)}");
// }
// catch (System.Exception)
// {

//     Console.WriteLine("Надо было вводить именно целое число!");
// }
