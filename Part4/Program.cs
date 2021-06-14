using System;

namespace Part4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Huy";
            person.PhoneNumber = 123456789;
            person.Email = "Huy@gmail.com";
            Console.WriteLine(person.ToString());
        }
    }
}