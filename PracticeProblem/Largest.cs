using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class Largest
    {
        public Largest()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter three numbers: \n");

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2)
            {
                if (num1 >= num3)
                    Console.WriteLine(num1 + " is the largest number");
                else
                    Console.WriteLine(num3 + " is the largest number");
            }

            else if (num2 >= num3)
                Console.WriteLine(num2 + " is the largest number");

            else
                Console.WriteLine(num3 + " is the largest number");

            Console.ReadLine();
        }
    }
}
