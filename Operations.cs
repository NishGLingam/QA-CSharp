using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Operations
    {
        public int A, B;
        public void add(int X, int Y)
        {
            Console.WriteLine("The result is " + (X + Y));
        }
        public void multiply(int X, int Y)
        {
            Console.WriteLine("The result is " + (X * Y));
        }
        public void subtract(int X, int Y)
        {
            Console.WriteLine("The result is " + (X - Y));
        }
        public void divide(float X, float Y)
        {
            float result;
            result = (float) (X / Y);
            Console.WriteLine((float) result);
        }
        public void SalaryCalc(float Salary)
        {
            float tax, net;
            if (Salary > 2000)
            {
                tax = Salary * 20/100;
            }
            else
            {
                tax = Salary * 10/100;
            }

            net = Salary - tax;
            Console.WriteLine("Gross Salary: " + Salary);
            Console.WriteLine("Tax: " + tax);
            Console.WriteLine("Net Salary: " + net);

        }
    }
}
