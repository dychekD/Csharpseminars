double distance (int xa, int ya, int za, int xb, int yb, int zb)
{
    double res;
    res = Math.Sqrt ((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
    return res;
}
try 
            {
            Console.Write ("enter x coordinate for first point ");
            int xa = Convert.ToInt32 (Console.ReadLine());
            Console.Write ("enter y coordinate for first point ");
            int ya = Convert.ToInt32 (Console.ReadLine());
            Console.Write ("enter z coordinate for first point ");
            int za = Convert.ToInt32 (Console.ReadLine());
            Console.Write ("enter x coordinate for second point ");
            int xb = Convert.ToInt32 (Console.ReadLine());
            Console.Write ("enter y coordinate for second point ");
            int yb = Convert.ToInt32 (Console.ReadLine());
            Console.Write ("enter z coordinate for second point ");
            int zb = Convert.ToInt32 (Console.ReadLine());
            double rez = distance (xa, ya, za, xb, yb, zb);
            Console.WriteLine ($"square between first point with coordinates ({xa},{ya},{za}), second pont with coordinates ({xb},{yb},{zb}) equals {rez}");
            }
        catch
            {
                Console.WriteLine("please enter integers");
            }

