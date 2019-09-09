using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int left = (n - 1)/ 2;
            int right = n / 2 ;

            for (int row = 0; row < Math.Ceiling(n / 2f); row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if(col == left || col == right)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                left--;
                right++;
                Console.WriteLine();
            }

            left = 1;
            right = n - 2;
            for (int row = 0; row < (n - 1) / 2; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == left || col == right)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                left++;
                right--;
                Console.WriteLine();
            }
        }
    }
}
