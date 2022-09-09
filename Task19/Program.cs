void palindrome (string dit5)
{
    if (dit5 [0] == dit5 [4] && dit5 [1] == dit5 [3]) Console.WriteLine ("it is a palindrome");
    else Console.WriteLine ("it is not a palindrome");
}


Console.WriteLine ("please enter a 5-digit number");
try
{
int number = Convert.ToInt32 (Console.ReadLine());
string dit5 = Convert.ToString (number);
palindrome (dit5);
}
catch
{
    Console.WriteLine ("please enter an integer");
}