﻿using System;

namespace NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 0;

            while (counter < 10) {
                counter = counter + 1;

                int counter2 = counter;

                while (counter2 < 5) {
                    Console.WriteLine(name);
                    counter2 = counter2 + 1;
                }
            }

            Console.WriteLine("Goodbye "+ name);
        }
    }
}
