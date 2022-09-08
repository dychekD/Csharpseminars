string Cubes (int basic)
{
    string result = string.Empty;
    double number;
    if (basic > 0) 
    {
        int count = 1;
        while (count <= basic)
    {
        number = Math.Pow (count, 3);
        result = result+number+", ";
        count++;
    }
    }
    else if (basic < 0) 
    {
        int Mcount = -1;
        while (Mcount >= basic)
    {
        number = Math.Pow (Mcount, 3);
        result = result+number+", ";
        Mcount = Mcount -1;
    }
    }
    else Console.WriteLine ("please enter something different from 0");
    return result;
}
Console.WriteLine ("enter a number");
try
{
int basic = Convert.ToInt32 (Console.ReadLine());
string Ready = Cubes (basic);
Console.WriteLine(Ready);
}
catch
{
    Console.WriteLine("please enter integers");
}

