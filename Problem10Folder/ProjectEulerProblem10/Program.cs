using System;
using System.Collections.Generic;

namespace ProjectEulerProblem10
{
    public class Program
    {
        public static long Solve(int n)
        {

            List<int> primes = new List<int>();
            long res = 0;
            for (var i = 2; i < n; i++)
            {
                if (IsPrime(i, primes))
                {
                    res += i;
                }
            }

            return res;
        }

        private static bool IsPrime(int num, List<int> primes)
        {
            var cutoff = Math.Sqrt(num);
            foreach (var p in primes)
            {
                if (num % p == 0)
                {
                    return false;
                }

                if (p > cutoff)
                {
                    primes.Add(num);
                    return true;
                }
            }

            primes.Add(num);
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
