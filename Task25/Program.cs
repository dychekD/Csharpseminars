// int Digitss (double N)
// {   
//     int result = 0;
//     while (N % 1 < 0) N = N * 10;
//     while (N > 0)
//     {
//         N = N / 10;
//         result++;
//     }
//     return result;
// }
// Console.WriteLine ("please enter a number ");
// try
// {
//     double N = Convert.ToDouble (Console.ReadLine ());
//     Console.WriteLine ($"Number of digits in this number equals {Digitss (N)}");
// }
// catch
// {
//     Console.WriteLine ("please enter numbers ");
// }

int Digitss (string N)
{   
    int size = N.Length;
    int i = 0;
    int coma = 0;
    string Inter = string.Empty;
    while (i< size)
    {
        if (N [i] == ',') 
        {
            coma = i;
            for (i = 0; i<coma; i++) Inter = Inter+N [i];
            for (i = coma +1; i<size; i++) Inter = Inter+N [i];
            break;
        }
        else if (N [i] == '.') 
        {
            coma = i;
            for (i = 0; i<coma; i++) Inter = Inter+N [i];
            for (i = coma +1; i<size; i++) Inter = Inter+N [i];   
            break;
        }
        else i++;
    }
    int newN = 0;
    if (Inter != string.Empty) newN = int.Parse(Inter);
    else newN = int.Parse(N);
    int result = 0;
    while (newN > 0)
    {
        newN = newN / 10;
        result++;
    }
    return result;
}
Console.WriteLine ("please enter a number ");
string N = Console.ReadLine ();
Console.WriteLine ($"Number of digits in this number equals {Digitss (N)}");


