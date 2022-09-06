string CheckChetvert(int chet)
            {    
            string res;
            if (chet == 1) res= "x > 0, y > 0";
            else if (chet == 2) res="x < 0, y > 0";
            else if (chet == 3) res= "x < 0, y < 0";
            else if (chet == 4) res="x > 0, y < 0";
            else res = "incorrect number";
            return res;
            }
        
        try 
            {
            Console.Write ("enter number from 1 to 4 ");
            int chet = Convert.ToInt32 (Console.ReadLine());
            string rez = CheckChetvert(chet);
            Console.WriteLine (rez);
            }
        catch
            {
                Console.WriteLine("Надо было вводить именно целые числа");
            }
