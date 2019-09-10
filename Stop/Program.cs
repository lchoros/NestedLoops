using System;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 4 * n + 3;
            int dots = n + 1;
            int underscore = 2 * n + 1;
            Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('_', underscore));
            underscore -= 2;
            dots--;
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', dots), new string('_', underscore));
                dots--;
                underscore += 2;
            }
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', (underscore - 5) / 2));
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', row), new string('_', underscore));
                underscore -= 2;
            }
            Console.WriteLine();
        }
    }
}
