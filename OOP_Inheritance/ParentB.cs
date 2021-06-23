using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Inheritance
{
    public class ParentB : ParentA
    {
        public string Location;

        public void GetUserDetails()
        {
            Console.WriteLine(" Emp Name (Parent B): " + Name);
            Console.WriteLine(" Emp Location: " + Location);
        }

    }
}
