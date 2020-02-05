using System;
using System.Collections.Generic;
using System.Text;
using BehaviourDesignPattern;

namespace ExampleLibrary
{
    public class ChainOfResponsibilityExample : IExample
    {
        public void PrintResult()
        {
            try
            {
                var l1Support=new Level1Support();
                var l2Support = new Level2Support();
                var l3Support = new Level3Support();
                var requestAssign=new RequestAssign();
                l1Support.AssignToNextLevel(l2Support).AssignToNextLevel(l3Support);
                requestAssign.HandleRequest(l1Support,"L3");
                requestAssign.HandleRequest(l3Support, "L1");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
            }
        }
    }
}
