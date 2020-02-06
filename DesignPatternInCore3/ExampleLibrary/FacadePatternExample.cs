using System;
using System.Collections.Generic;
using System.Text;
using StructuralDesignPattern;

namespace ExampleLibrary
{
    public class FacadePatternExample:IExample
    {
        public void PrintResult()
        {
            var deskMember = new OfficeDeskFacade();
            deskMember.SendPersonalEmail();
            deskMember.SendRegularCab();
        }
    }
}
