using System;

namespace ConsoleApp1
{
    public abstract class People
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int WorkDay { set; get; }
        public virtual string Role{
            get { return "People"; }
        }
        public virtual double Coefficients
        {
            get { return 2.2D; }
        }
        public double Salary
        {
            get { return (WorkDay * 100000) * Coefficients; }
        }

        public override string ToString()
        {
            new DateTime().ToSystemDate();
            return $"Name: {FirstName} {LastName} \t" +
                   $"Role: {Role} \t" +
                   $"Salary: {Salary.ToCurrency()} \n";
        }
    }
}