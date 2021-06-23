using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Inheritance
{
    public class Child: ParentB
    {
        public int Age;

        public void GetAge()
        {
            Console.WriteLine(" Age: " + Age);
        }

    }
}
