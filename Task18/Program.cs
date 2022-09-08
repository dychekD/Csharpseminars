double distance (int N, int [] iarr, int [] jarr)
{
    double member = 0;
    for (int i = 0; i < N; i++)
    {
        member = member + ((jarr[i] - iarr [i])*(jarr[i] - iarr [i]));
    }
    double res = Math.Sqrt (member);
    return res;
}

Console.WriteLine ("enter number of dimesions");
try 
            {
            int N = Convert.ToInt32 (Console.ReadLine());
            int [] iarr = new int [N];
            Console.WriteLine ("enter coordinates of the first point ");
            for (int i = 0; i < N; i++)
            {
                iarr [i] = Convert.ToInt32 (Console.ReadLine());
            }
            int [] jarr = new int [N];
            Console.WriteLine ("enter coordinates of the second point ");
            for (int i = 0; i < N; i++)
            {
                jarr [i] = Convert.ToInt32 (Console.ReadLine());
            }
            double rez = distance (N, iarr, jarr);
            Console.WriteLine ($"distance between two points equals {rez}");
            }
        catch
            {
                Console.WriteLine("please enter integers");
            }

