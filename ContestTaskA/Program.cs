using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestTaskA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console
                .ReadLine()
                .Split()
                .Select(x => Int32.Parse(x))
                .ToArray();
            int dist = Math.Abs(arr[0] - arr[1]);
            if (dist % 10 == 0)
            {
                Console.WriteLine(dist / 10);
            }
            else
            {
                Console.WriteLine(dist / 10 + 1);
            }
            

            Console.ReadLine();
        }
    }
}
