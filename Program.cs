using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations ops;
            ops = new Operations();
            ops.divide(5, 2);
            ops.SalaryCalc(35);
            Console.Read();
        }
    }
}
