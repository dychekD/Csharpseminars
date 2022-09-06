double distance (int xa, int ya, int xb, int yb)
{
    double res;
    res = Math.Sqrt ((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));
    return res;
}
try 
            {
            Console.Write ("enter x coordinate for first point ");
            int xa = Convert.ToInt32 (Console.ReadLine());
            Console.Write ("enter y coordinate for first point ");
            int ya = Convert.ToInt32 (Console.ReadLine());
            Console.Write ("enter x coordinate for second point ");
            int xb = Convert.ToInt32 (Console.ReadLine());
            Console.Write ("enter y coordinate for second point ");
            int yb = Convert.ToInt32 (Console.ReadLine());
            double rez = distance (xa, ya, xb, yb);
            Console.WriteLine ($"distance between first point with coordinates ({xa},{ya}) and second pont with coordinates ({xb},{yb}) equals {rez}");
            }
        catch
            {
                Console.WriteLine("please enter integers");
            }


