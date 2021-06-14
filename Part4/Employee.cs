using System;

namespace Part4
{
    public abstract class Employee : Person
    {
        public String Department { get; set; }
        public int salary { get; set; }
        public DateTime DateHired { get; set; }

        public abstract void CalculateBonus();
        public abstract void CalculateVacation();
    }
}