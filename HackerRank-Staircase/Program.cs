using System;

namespace HackerRank_Staircase
{
    class Program
    {
        static void Staircase(int n)
        {
             //For loop starting with the rows which 'y' represents 
            for (int y = 0; y < n; y++)
            {
                //Nested for loop starting with the columns which 'x' represents  
                for (int x = 0; x < n; x++)
                {
                    //Condition statement where we check if the value in the column (x) is equal to or greater than the value in the row (y) then it will print out '#'
                    if (x >= y)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Staircase(n);
        }
    }
}
