using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestTaskB
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            char c = 'X';

            string s = new String(c, n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
            /*
            XXXX
            XX X
            X XX
            XXXX
            */

        }
    }
}
