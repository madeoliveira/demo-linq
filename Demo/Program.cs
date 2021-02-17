using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 3, 4, 5, 10,11,14 };

            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
