using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehaviourDesignPattern
{
    public interface ICandidateWatcher
    {
        void CandidateAvailableForInterview(ICandidate candidate);
        CandidateCategory TypeOfCandidateExpecting { get; }
        int MinimumExperanceExpecting { get; }
    }

    public class DotNetCandidateWatcher : ICandidateWatcher
    {
        public CandidateCategory TypeOfCandidateExpecting => CandidateCategory.DotNet;

        public int MinimumExperanceExpecting => 3;

        public void CandidateAvailableForInterview(ICandidate candidate)
        {
            Console.WriteLine($"Interview taking of {candidate.Name} for DotNet profile");
        }
    }

    public class JavaCandidateWatcher : ICandidateWatcher
    {
        public CandidateCategory TypeOfCandidateExpecting => CandidateCategory.Java;

        public int MinimumExperanceExpecting => 2;

        public void CandidateAvailableForInterview(ICandidate candidate)
        {
            Console.WriteLine($"Interview taking of {candidate.Name} for Java profile");
        }
    }

    public enum CandidateCategory
    {
        DotNet,
        Java,
        Python
    }
    public interface ICandidate
    {
       CandidateCategory Category { get;}
       string Name { get;}
       double Experiance { get; }
       int Salary { get; }
    }

    public class DotNetCandidate:ICandidate
    {
        public DotNetCandidate(string name,double experiance,int salary)
        {
            Name = name;
            Experiance = experiance;
            Salary = salary;

        }
        public CandidateCategory Category => CandidateCategory.DotNet;
        public string Name { get; }
        public double Experiance { get; }
        public int Salary { get; }
    }

    public class JavaCandidate : ICandidate
    {
        public JavaCandidate(string name, double experiance, int salary)
        {
            Name = name;
            Experiance = experiance;
            Salary = salary;

        }
        public CandidateCategory Category => CandidateCategory.Java;
        public string Name { get; }
        public double Experiance { get; }
        public int Salary { get; }
    }
    public interface ICandidateManager
    {
        void AddWatcher(ICandidateWatcher watcher);
        void RemoveWatcher(ICandidateWatcher watcher);
        void Notify(ICandidate candidate);
        void CandidateCameForInterview(ICandidate candidate);
    }

    public class CandidateManager:ICandidateManager
    {
        readonly List<ICandidateWatcher> _candidateWatchers=new List<ICandidateWatcher>();
        public void AddWatcher(ICandidateWatcher watcher)
        {
            _candidateWatchers.Add(watcher);
        }

        public void RemoveWatcher(ICandidateWatcher watcher)
        {
            _candidateWatchers.Remove(watcher);
        }

        public void Notify(ICandidate candidate)
        {
            var availableInterviewee = _candidateWatchers.Where(c =>
                c.TypeOfCandidateExpecting == candidate.Category && candidate.Experiance >= c.MinimumExperanceExpecting).ToList();
            if (availableInterviewee.Count < 1)
                throw new Exception($"No one available for taking interview of {candidate.Category.ToString()} or experiance is too low");

            foreach (var candidateWatcher in availableInterviewee)
            {
                candidateWatcher.CandidateAvailableForInterview(candidate);
            }
        }

        public void CandidateCameForInterview(ICandidate candidate)
        {
            Notify(candidate);
        }
    }

   
}
