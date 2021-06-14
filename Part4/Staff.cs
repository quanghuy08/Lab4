using System;

namespace Part4
{
    public class Staff : Employee
    {
        public int Title { get; set; }
        public override void CalculateBonus()
        {
            double SalaryBonus = 0.06 * salary;
            Console.WriteLine(SalaryBonus);
        }

        public override void CalculateVacation()
        {
            if (Title == 5)
            {
                Console.WriteLine("4 weeks.");
            }
            else
            {
                Console.WriteLine("3 weeks.");
            }
        }
    }
}