using System;

namespace Mytest
{
    class Program
    {
        static Boolean Prime(int i)
        {
 
            if (i % 2 == 0 && i != 2)
                return false;
            else
            {
                for (int j = 3;
                        j <= Math.Sqrt(i);
                        j += 2)
                {
                    if (i % j == 0)
                        return false;
                }
                return true;
            }
        }
        public static void Main(String[] args)
        {

            int c = 0;
            int N = 20;

            for (int i = 2;
                    i <= Math.Sqrt(N); i++)
            {
                if (Prime(i))
                {
                    if (N % i == 0)
                    {
                        c++;
                        if (Prime(N / i) &&
                                i != (N / i))
                            c++;
                    }
                }
            }
            Console.Write(Math.Pow(2, c) - 1);
        }
    }
}
