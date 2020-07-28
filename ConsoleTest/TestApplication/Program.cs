using System;

namespace TestApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            //int result = Multiply(a, b);
            int result = RecurseMultiPly(a, b);

            Console.WriteLine($"Multiplications of numbers {a}, {b} without * operator is: ", result);
        }

        public static int Multiply(int a, int b)
        {
            int output = 0;
            while (b > 0)
            {
                output += a;
                b--;
            }
            return output;
        }

       public static int RecurseMultiPly(int a, int b)
        {
            int outPut = 0;
            if (b > 0)
            {
                outPut = a + RecurseMultiPly(a, b - 1);
            }
            if (b < 0)
            {
                outPut = RecurseMultiPly(-a, -b);
            }
            if (b == 0)
                return 0;
            return outPut;
        }
    }
}
