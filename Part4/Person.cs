using System;

namespace Part4
{
    public class Person
    {
         public String Name { get; set; }
                public int PhoneNumber { get; set; }
                public String Email { get; set; }
        
                public override string ToString()
                {
                    return $"Name: {Name}, Phone number: {PhoneNumber}, Email: {Email}";
                }
    }
}