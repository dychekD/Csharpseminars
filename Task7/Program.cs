void ThirdDigit (int somenumber)
{
    if (somenumber % 100 == somenumber) Console.WriteLine ("there is no third digit");
    else
        {
        int temp = somenumber;
        while (temp > 999)
            {
                temp = temp / 10;       
            }
        Console.WriteLine ($"third digit is {temp % 10}");
        }
}
Console.WriteLine ("enter a number");
int somenumber = Convert.ToInt32 (Console.ReadLine());
ThirdDigit (somenumber);