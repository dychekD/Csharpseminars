string palindrome (string dit)
{
string res = string.Empty;
int size = dit.Length;
int left = 0;
int right = size-1;
while (left < right)
{
    if (dit [left]!=dit [right]) 
    {
        res = "it is not a palindrome";
        break;
    }
    else if (dit [left]==dit [right]) res = "it is a palindrome";
    right = right -1;
    left++;
}
return res;
}


Console.WriteLine ("please enter a number");
try
{
int number = Convert.ToInt32 (Console.ReadLine());
string dit = Convert.ToString (number);
string rez = palindrome (dit);
Console.WriteLine (rez);
}
catch
{
    Console.WriteLine ("please enter an integer");
}
