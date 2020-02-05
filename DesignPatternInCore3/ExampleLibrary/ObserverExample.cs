using System;
using System.Collections.Generic;
using System.Text;
using BehaviourDesignPattern;

namespace ExampleLibrary
{
    public class ObserverExample : IExample
    {
        public void PrintResult()
        {
            try
            {
                var dotnewWatcher = new DotNetCandidateWatcher();
                var javaWatcher = new JavaCandidateWatcher();
                var candidateManager = new CandidateManager();
                candidateManager.AddWatcher(dotnewWatcher);
                candidateManager.AddWatcher(javaWatcher);
                candidateManager.CandidateCameForInterview(new DotNetCandidate("ujjwal", 5, 5000));
                candidateManager.CandidateCameForInterview(new DotNetCandidate("Chandra", 6, 5000));
                candidateManager.RemoveWatcher(dotnewWatcher);
                candidateManager.CandidateCameForInterview(new DotNetCandidate("Sam", 6, 5000));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
            }
        }
    }
}
