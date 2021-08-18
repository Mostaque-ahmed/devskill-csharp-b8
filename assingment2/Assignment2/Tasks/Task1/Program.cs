using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = IsPrime(19);
            Console.WriteLine(result);
        }

        public static bool IsPrime(int number)
        {
           
            if (number == 1)
                return false;
            if (number == 2)
                return true;
            for (int i = 2; i<number; i++)
            { if (number % i == 0)
                    return false;
                else
                    return true;

            }
            //
            throw new NotImplementedException();
        }
    }
}
