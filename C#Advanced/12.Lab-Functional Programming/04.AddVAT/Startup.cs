﻿namespace _04.AddVAT
{
    using System;
    using System.Linq;

    public class Startup
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n * 1.2)
                .ToList()
                .ForEach(n => Console.WriteLine($"{n:f2}"));
        }
    }
}
