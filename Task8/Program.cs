void SorryForTranslit (int numProg)
{
    if (numProg % 10 == 0 || numProg % 10 >= 5 ) Console.WriteLine ($"{numProg} programmistov");
    else if (numProg % 10 == 1) Console.WriteLine ($"{numProg} programmist");
    else Console.WriteLine ($"{numProg} programmista"); 
}
Console.WriteLine ("enter a positive integer");
int numProg = Convert.ToInt32 (Console.ReadLine());
SorryForTranslit (numProg);