// triangular 

void PrintArray(double [] mmm)
            {
                       for (int i=0;i<mmm.Length;i++) 
                {
                    if (i!=mmm.Length-1) Console.Write($"{mmm[i]}; ");
                    else Console.WriteLine($"{mmm[i]}");
                }
            }
int Triangular (int arg1, int arg2, int arg3)
{
    int result = 0;
    if (arg1 < arg2+arg3 && arg2 < arg1+arg3 && arg3 < arg1+arg2) result = 1;
    return result;
}

double [] Angles (int arg1, int arg2, int arg3)
{
    double [] ABC = new double [3];
    double a2 = arg1*arg1;
    double b2 = arg2*arg2;
    double c2 = arg3*arg3;
    double cosA = (b2+c2-a2)/(2*arg2*arg3);
    double alfa = Math.Acos (cosA);
    double cosB = (a2+c2-b2)/ (2*arg1*arg3);
    double beta = Math.Acos (cosB);
    ABC [0] = Math.Round ((alfa * (180/ Math.PI)), 2);
    ABC [1] = Math.Round ((beta * (180/ Math.PI)), 2);
    ABC [2] = Math.Round ((180 - (ABC [0] + ABC [1])), 2);
    return ABC;
}

string Sides (int arg1, int arg2, int arg3)
{
    string result = "isosceles triangular";
    if (arg1 == arg2 && arg1 == arg3) result = "equilateral triangular";
    else if (arg1*arg1 == arg2*arg2+arg3*arg3 || arg2*arg2==arg1*arg1+arg3*arg3 || arg3*arg3==arg1*arg1+arg2*arg2) result = "right-angled triangular";
    else if (arg1!=arg2 && arg1!=arg3 && arg2!=arg3) result = "neither equilateral nor isosceles triangular";
    return result;
}

double [] Stats (int arg1, int arg2, int arg3)
{
    double [] stat = new double [2];
    stat [0] = Convert.ToDouble (arg1+arg2+arg3);
    double half = stat [0] /2;
    stat [1] = Convert.ToDouble (Math.Sqrt(half*(half - arg1)*(half-arg2)*(half - arg3)));
    Console.WriteLine ($"perimeter equals {stat [0]}");
    Console.WriteLine ($"triangular's square equals {stat [1]}");
    return stat;
}

Console.WriteLine ("enter three integers");
int arg1 = Convert.ToInt32 (Console.ReadLine());
int arg2 = Convert.ToInt32 (Console.ReadLine());
int arg3 = Convert.ToInt32 (Console.ReadLine());
int tri = Triangular (arg1, arg2, arg3);
if (tri==0) Console.WriteLine ("it is not a triangular");
else if (tri==1) 
{
    Console.WriteLine ("it is a triangular");
    double [] res = Angles (arg1, arg2, arg3);
    Console.Write ("angles of this triangular are: ");
    PrintArray (res); 
    Console.WriteLine (Sides (arg1, arg2, arg3));
    double [] statsRes = Stats (arg1,arg2,arg3);
}