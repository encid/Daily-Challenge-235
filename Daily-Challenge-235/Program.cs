using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyChallenge235
{
    class Program
    {
        static void Main()
        {
            int a = 492;
            int b = 493;

            if (IsRuthAaron(a, b)) {
                Console.WriteLine("({0},{1}) VALID", a, b);
            }
            else
                Console.WriteLine("({0},{1}) NOT VALID", a, b);

            Console.WriteLine();

            Console.ReadKey();
        }

        public static List<int> GetPrimeFactors(int n)
        {
            var primes = new List<int>();
            
            while (n % 2 == 0) {
                primes.Add(2);
                n /= 2;
            }
            
            for (int i = 3; i <= Math.Sqrt(n); i += 2) {
                while (n % i == 0) {
                    primes.Add(i);
                    n /= i;
                }
            }
            
            if (n > 2)
                primes.Add(n);

            // trim duplicates
            return primes.Distinct().ToList();
        }

        public static int AddPrimeFactors(List<int> n)
        {
            int sum = 0;

            foreach (var num in n) {
                sum += num;
            }
            return sum;
        }

        public static bool IsRuthAaron(int a, int b)
        {
            var totalA = AddPrimeFactors(GetPrimeFactors(a));
            var totalB = AddPrimeFactors(GetPrimeFactors(b));
            
            return (totalA == totalB);
        }

        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++) {
                if (number % i == 0)
                    return false;
            }

            return true;
        }        
    }
}
