using System;
using System.Security.Cryptography;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // string value = Console.ReadLine();
            
            Guid test = Guid.NewGuid();
            Guid test1 = Guid.NewGuid();

            var check = Guid.NewGuid().ToString();

            Console.WriteLine("The hash code for \"{0}\" is: 0x{1:X8}, {1}",
                          check, check.GetHashCode());

            var arrValue = "".Split(" ");

            ulong sum = 0, x1;

            // test 1
            // test 2
            var x = Math.Sqrt(long.Parse(arrValue[0]));
            if (x * x < long.Parse(arrValue[0]))
            {
                x1 = (ulong)x;
            }
            else
            {
                x1 = (ulong)x - 1;
            }
            var y = Math.Sqrt(long.Parse(arrValue[1]));

            Console.Write(tong((ulong)y) - tong(x1));
        }

        static ulong tong(ulong n)
            {
                return n * (n + 1) * (2 * n + 1) / 6;
            }

    }
}
