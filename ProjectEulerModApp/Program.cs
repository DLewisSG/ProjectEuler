using System;

namespace ProjectEulerModApp
{
    public class Program
    {
        public static int Mod(int num)
        {
            var result = 0;
            for (int i = 0; i < num; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
        }
    }
}
