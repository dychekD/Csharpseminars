void SecondNumber (int threed)
{
    int second = threed / 10 % 10;
    Console.WriteLine ($"second digit is {second}");
}
Console.WriteLine ("enter 3-digit number");
int threed = Convert.ToInt32 (Console.ReadLine());
SecondNumber (threed);

