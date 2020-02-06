using System;
using System.Collections.Generic;
using System.Text;
using StructuralDesignPattern;

namespace ExampleLibrary
{
    public class DecoratorExample:IExample
    {
        public void PrintResult()
        {
            var permEmp = new PermanentEmployee(".Net employee", "Ujjwal");
            var tempEmp = new TemporaryEmployee("java employee", "ram");
            Console.WriteLine("Before Decorator");
            Console.WriteLine(permEmp.GetDetails());
            Console.WriteLine("After Decorator");
            var permDec=new PermEmployeeDecorator(permEmp);
            permDec.GetDetails();
            Console.WriteLine(permDec.GetDetails());

        }
    }
}
