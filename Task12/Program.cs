string Squares (int basic)
{
    string result = string.Empty;
    int count = 1;
    double number;
       while (count <= basic)
    {
        number = Math.Pow (count, 2);
        result = result+number+", ";
        count++;
    }
    return result;

}
Console.WriteLine (Squares (5));