using System;

namespace OOP_Inheritance
{
    class Program: Child
    {
        static void Main(string[] args)
        {
            

            Program obj = new Program();
            obj.Name = "Darshana";
            obj.Location = "New York";
            obj.Age = 30;

            // Single Level Inheritance 
            Console.WriteLine("------------------------ Single Inheritance ----------------------------");
            obj.GetName();

            // Multi Level Inheritance 

            Console.WriteLine("------------------------ Multi Level Inheritance ----------------------------");
            obj.GetUserDetails();
            obj.GetAge();
            Console.ReadLine();


        }
    }
}
