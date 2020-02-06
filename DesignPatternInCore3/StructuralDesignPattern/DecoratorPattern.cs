using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPattern
{
    public interface IEmployee
    {
        string GetName();
        string GetDetails();
    }

    public class PermanentEmployee : IEmployee
    {
        private string _details;
        private string _name;

        public PermanentEmployee(string details,string name)
        {
            _details = details;
            _name = name;
        }
        public string GetDetails()
        {
            return _details;
        }

        public string GetName()
        {
            return _name;
        }
    }

    public class TemporaryEmployee : IEmployee
    {
        private string _details;
        private string _name;

        public TemporaryEmployee(string details, string name)
        {
            _details = details;
            _name = name;
        }
        public string GetDetails()
        {
            return _details;
        }

        public string GetName()
        {
            return _name;
        }
    }

    public abstract class EmployeeDecorator : IEmployee
    {
        private IEmployee _employee;

        protected EmployeeDecorator(IEmployee employee)
        {
            _employee = employee;
        }

        public virtual string GetDetails()
        {
            return _employee.GetDetails();
        }

        public virtual string GetName()
        {
            return _employee.GetDetails();
        }
    }

    public class TempEmployeeDecorator : EmployeeDecorator
    {
        public TempEmployeeDecorator(IEmployee employee):base(employee)
        {
            
        }
        public override string GetDetails()
        {
            return base.GetDetails()+" with additional Details for temp employee";
        }
    }

    public class PermEmployeeDecorator : EmployeeDecorator
    {
        public PermEmployeeDecorator(IEmployee employee) : base(employee)
        {

        }
        public override string GetDetails()
        {
            return base.GetDetails() + " with additional Details for permanent employee";
        }
    }


}
