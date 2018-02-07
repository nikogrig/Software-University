﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._01_SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool[] array = new bool[n + 1];

            for (int i = 0; i <= n; i++)
            {
                array[i] = true;
            }

            array[0] = false;
            array[1] = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == true)
                {
                    for (int a = 2; (a * i) <= n; a++)
                    {
                        array[a * i] = false;
                    }
                }
            }
            for (int j = 2; j <= n; j++)
            {
                if (array[j] == true)

                { Console.Write(j + " "); }
            }

            Console.WriteLine();
        }
    }
}
