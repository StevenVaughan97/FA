﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string str = "";
                if (i % 3 == 0)
                {
                    str += "Fizz";
                }
                if (i % 5 == 0)
                {
                    str += "Buzz";
                }
                if (str.Length == 0)
                {
                    str = i.ToString();
                }
                Console.WriteLine(str);

            }
        }
    }
}
