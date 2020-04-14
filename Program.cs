using System;

namespace REFandOUTINC
{
    class Program
    {
        static void Main(string[] args)
        {

            int iNum = 10;
            Increment(iNum);
            Console.Write("value of a is:" + iNum);
            Console.Read();

        }
        public static void Increment(int b)
        {
            b = b + 10;
        }
    }
}
