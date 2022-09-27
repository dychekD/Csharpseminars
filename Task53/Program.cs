// **Задача 68:** Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann (int m, int n)
{
    if (m==0) return n+1;
    else if (n==0 && m>0) return Ackermann (m-1,1);
    else return (Ackermann (m-1,  Ackermann (m, n-1)));
}
try 
{
    Console.WriteLine("enter first integer");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter second integer");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m > 3 && n > 0) Console.WriteLine("the value of the function is too big to show");
    else if (m > 4 || n > 5) Console.WriteLine("the value of the function is too big to show");
    else if (m < 0 || n < 0) Console.WriteLine("please enter positive integers");
    else Console.WriteLine(Ackermann(m, n));
}
catch
{
    Console.WriteLine ("please enter integers");
}
