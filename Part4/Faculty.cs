using System;

namespace Part4
{
    public class Faculty : Employee
    {
         public int OfficeHours { get; set; }
                public String Rank { get; set; }
                public override void CalculateBonus()
                {
                    double SalaryBonus = 1000 + 0.05 * salary;
                    Console.WriteLine(SalaryBonus);
                }
        
                public override void CalculateVacation()
                {
                    if (OfficeHours >= 3)
                    {
                        Console.WriteLine("5 weeks.");
                    }
                    else if (OfficeHours >= 3 && Rank == "Senior Lecturer")
                    {
                        Console.WriteLine("6 weeks.");
                    }
                    else
                    {
                        Console.WriteLine("4 weeks.");
                    }
                }
    }
}