using System;

namespace ProjectEulerProblem19
{
    public class CountSundays
    {
        public static int Solve(DateTime start, DateTime end)
        {
            var result = 0;

            while (start <= end)
            {
                if (start.Day == 1 && start.DayOfWeek == DayOfWeek.Sunday)
                {
                    result++;
                }

                start = start.AddDays(1);
            }

            return result;

        }

        static void Main()
        {
            Console.WriteLine("Hello World");
        }
    }
}
