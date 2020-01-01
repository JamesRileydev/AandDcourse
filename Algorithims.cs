using System;
using System.Collections.Generic;
using System.Linq;

namespace AandDcourse
{
    class Algorithims
    {
        public void FizzBuzz(int n)
        {
            var str = "";

            for (int i = 1; i <= n; i++)
            {
                str = (i % 5 == 0 && i % 3 == 0) ? "fizzbuzz" : i % 3 == 0 ? "buzz" : i % 5 == 0 ? "fizz" : $"{i}";
                Console.WriteLine(str);
            }
        }

        public char MaxChars(string s)
        {
            var d = new Dictionary<char, int>();

            foreach (var ch in s)
            {
                if (!d.ContainsKey(ch))
                {
                    d[ch] = 1;
                }
                else
                {
                    d[ch]++;
                }
            }

            var max = d.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

            Console.WriteLine(max);

            return max;
        }


    }
}
