void Delete2 (int anynumber)
{
    if (anynumber % 10 == anynumber) Console.WriteLine ("there is no second digit");
    else
    {
        int count = 0;
        int temp = anynumber;
        while (temp / 10 > 9)
        {
            temp = temp / 10;
            count++;
        }
        temp = temp / 10;
        if (count == 0) Console.WriteLine ($"{temp}");
        else Console.WriteLine ($"{temp}{anynumber % (Math.Pow (10, count))}");
    }
}
Console.WriteLine ("enter a number");
int anynumber = Convert.ToInt32 (Console.ReadLine());
Delete2 (anynumber);
