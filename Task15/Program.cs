int [] arr = {1, 5, 6, 3, 2, 1, 1, 6, 8, 3};
void PrintArray (int [] array)
{
    int count = array.Length;
    for (int i=0; i < count; i++)
    {
        Console.Write ($"{array [i]} ");
    }
    Console.WriteLine ();
}


void SelectionSort (int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int MinPos = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array [j] < array [MinPos]) MinPos=j;
            int temporary = array [i];
            array [i] = array [MinPos];
            array [MinPos] = temporary;
        }
    }
}
PrintArray (arr);
SelectionSort (arr);
PrintArray (arr);