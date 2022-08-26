using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class MonthtlyHrs
    {
        public abstract void HoursPerMonth();

    }
    public class Implementatin : MonthtlyHrs
    {
        public override void HoursPerMonth()
        {
          
            var Monthly_Hours = new ArrayList();
            int Is_Full_Time = 1;
            int Is_Part_Time = 2;
            int empHrs = 0;
            int WorkingDays = 20;
            int dailyWage = 100;
            int monthlyHours = 0;
            int num_of_comp = 5;
            while (num_of_comp > 0)
            {
                monthlyHours = 0;
                for (int i = 0; i <= WorkingDays; i++)
                {
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case 1:
                            empHrs = 8;
                            break;
                        case 2:
                            empHrs = 4;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    monthlyHours = monthlyHours + empHrs;
                }
                Monthly_Hours.Add(monthlyHours);
                num_of_comp--;
            }
            //Console.WriteLine("The monthly hours of employee is : " + monthlyHours);
            foreach (var item in Monthly_Hours)
            {
                Console.WriteLine("Company hours: " + item + " hrs ");
            }
        }
    }

}
