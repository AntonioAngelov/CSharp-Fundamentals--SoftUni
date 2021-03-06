﻿namespace _02.SumNumbers
{
    using System;
    using System.Linq;

    public class Startup
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(nums.Length);
            Console.WriteLine(nums.Sum());
        }
    }
}
