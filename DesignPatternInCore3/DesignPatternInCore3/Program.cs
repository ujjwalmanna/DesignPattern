using System;
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
            Console.WriteLine("========================================ChainOfResponsibilityExample===============================");
            var corExample = new ChainOfResponsibilityExample();
            corExample.PrintResult();
            Console.WriteLine("*************************End of ChainOfResponsibilityExample************************************");
            Console.WriteLine("========================================FacadeExample===============================");
            var facadExample = new FacadePatternExample();
            facadExample.PrintResult();
            Console.WriteLine("*************************End of FacadeExample************************************");
            Console.WriteLine("========================================Decorator Example===============================");
            var decoratorExample = new DecoratorExample();
            decoratorExample.PrintResult();
            Console.WriteLine("*************************End of Decorator Example************************************");
            Console.WriteLine("========================================Bridge Example===============================");
            var bridgeExample = new BridgePatternExample();
            bridgeExample.PrintResult();
            Console.WriteLine("*************************End of Bridge Example************************************");

            Console.ReadKey();
        }
    }
}
