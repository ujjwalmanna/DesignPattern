﻿using System;
using ExampleLibrary;

namespace DesignPatternInCore3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================ObserverPatternExample===============================");
            var observerExample = new ObserverExample();
            observerExample.PrintResult();
            Console.WriteLine("*************************End of ObserverPatternExampl************************************");
            Console.ReadKey();
        }
    }
}
