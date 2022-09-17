// reverse array

// int[] FillArray(int size)
//             {
//             int[] mas = new int[size];

//             for (int i=0;i<size;i++) 
//                 {
//                     mas[i]= new Random().Next(-10,11);
//                 }
//             return mas;
//             }
//       void PrintArray(int[] mmm)
//             {
//                        for (int i=0;i<mmm.Length;i++) 
//                 {
//                     if (i!=mmm.Length-1) Console.Write($"{mmm[i]}, ");
//                     else Console.WriteLine($"{mmm[i]}");
//                 }
//             }

//       int[] Reverse1(int[] mmm)
//       {
//         int[] revmas = new int [mmm.Length];
//         for (int i=0;i<mmm.Length; i++) revmas[i]=mmm[mmm.Length-1-i];
//         return revmas;
        
//       }
      
//       int[] array = FillArray(10);
//       PrintArray(array);
//       PrintArray(Reverse1(array));

// triangular 

// string [] Triangular (int arg1, int arg2, int arg3)
// {
//     string [] Stats = new string [6];
//     Stats [0] = "not a triangular";
//     if (arg1 < arg2+arg3 && arg2 < arg1+arg3 && arg3 < arg1+arg2) 
//      {
//         Stats [0] = "it can be a triangular";
//         Stats [1] = "not peculiar";
//         if (arg1==arg2 ||  arg1==arg3 || arg2==arg3) Stats [1] = "равнобедренный";
//         if (arg1==arg2==arg3) Stats[1] = "равносторонний";
//         Stats [2] = arg1+arg2+arg3;


//      }

//     return res;
// }

// Console.WriteLine ("enter three integers");
// int arg1 = Convert.ToInt32 (Console.ReadLine());
// int arg2 = Convert.ToInt32 (Console.ReadLine());
// int arg3 = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine (Triangular (arg1, arg2, arg3));

// Console.WriteLine("введите число");
// int n = int.Parse(Console.ReadLine());

// while (n2==0) 
// {
// Console.WriteLine(n%2);
// n=n/2;
// }

// convert from decimal to binary numeral system
// string Convert2 (int N)
// {
//     string result = String.Empty;
//     while (N > 0)
//         {
//             result = N%2+result;
//             N = N/2;
//         }
//     return result;
// }

// Console.WriteLine ("enter an integer");
// int arg1 = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine (Convert2 (arg1));

// int [] Fibo (int N)
// {
//     int [] Fib = new int [N];
//     Fib [0] = 0;
//     Fib [1] = 1;
//     for (int i = 2; i < Fib.Length; i++)
//     {
//         Fib [i] = Fib [i-1]+ Fib [i-2];
//     }
//     return Fib;
// }
// void PrintArray(int[] mmm)
//             {
//                        for (int i=0;i<mmm.Length;i++) 
//                 {
//                     if (i!=mmm.Length-1) Console.Write($"{mmm[i]}, ");
//                     else Console.WriteLine($"{mmm[i]}");
//                 }
//             }
// Console.WriteLine ("enter an integer");
// int arg1 = Convert.ToInt32 (Console.ReadLine());
// PrintArray (Fibo (arg1));

// int [] Copy (int [] arr)
// {
//     int [] copypaste = new int [arr.Length];
//     for (int i = 0; i < arr.Length; i++) copypaste [i] = arr [i];
//     return copypaste;
// }
// int[] FillArray(int size)
//             {
//             int[] mas = new int[size];

//             for (int i=0;i<size;i++) 
//                 {
//                     mas[i]= new Random().Next(-10,11);
//                 }
//             return mas;
//             }
// void PrintArray(int[] mmm)
//             {
//                        for (int i=0;i<mmm.Length;i++) 
//                 {
//                     if (i!=mmm.Length-1) Console.Write($"{mmm[i]}, ");
//                     else Console.WriteLine($"{mmm[i]}");
//                 }
//             }
// Console.WriteLine ("enter size of array");
// int arg1 = Convert.ToInt32 (Console.ReadLine());
// int [] res = FillArray (arg1);
// int [] res2 = Copy (res);
// PrintArray (res);
// res [0]= 99999;
// PrintArray (res2);
// Console.WriteLine ("copypaste of array");
// PrintArray (Copy (res));