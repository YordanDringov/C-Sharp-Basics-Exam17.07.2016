using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 3 * n + 2;
            int width = 5 * n;

            Console.WriteLine("{0}{1}{0}", new string('.',n), new string('*', width - 2*n));

            for (int i = 1; i <=n; i++)
            {
                if (i == n)
                {
                    Console.WriteLine("{0}", new string('*', 5 * n));break;
                }
                Console.WriteLine("{0}*{1}*{0}", new string('.', n-i),
                    new string('.', 5*n - 2*(n-i) - 2));
                
            }

            for (int i = 1; i <= height - (n+1); i++)
            {
                if (i == height - (n+1))
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('*', 5 * n - 2 * i - 2));break;
                }
                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', 5*n - 2*i - 2));

            }
            
        }
    }
}
