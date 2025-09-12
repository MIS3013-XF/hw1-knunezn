// HW1b Grade

// Your Name:
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double part;
            double hmwrk;
            double e1;
            double e2;
            double e3;

            const double p = 0.0015;
            const double h = 0.0020;
            const double exam1 = 0.0015;
            const double exam2 = 0.0025;
            const double exam3 = 0.0025;

            double sum;

            string partAsString;
            string hmwrkAsString;
            string e1AsString;
            string e2AsString;
            string e3AsString;



            Console.WriteLine("What is your first name?");

            string fname = Console.ReadLine();

            Console.WriteLine("What is your last name?");

            string lname = Console.ReadLine();

            Console.WriteLine("What is your student id?");

            var studentid = Console.ReadLine();

            

            Console.WriteLine("What is your overall percentage grade for participations?"); // 15%

            partAsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for homeworks?"); // 20%

            hmwrkAsString = Console.ReadLine();


            Console.WriteLine("What is your overall percentage grade for Exam 1?"); // 15%

            e1AsString = Console.ReadLine();


            Console.WriteLine("What is your overall percentage grade for Exam 2?"); // 25%

            e2AsString = Console.ReadLine();


            Console.WriteLine("What is your overall percentage grade for Exam 3"); // 25%

            e3AsString = Console.ReadLine();

            part = Convert.ToDouble(partAsString);
            hmwrk = Convert.ToDouble(hmwrkAsString);
            e1 = Convert.ToDouble(e1AsString);
            e2 = Convert.ToDouble(e2AsString);
            e3 = Convert.ToDouble(e3AsString);

            // const double p = .15;
           // const double h = .20;
           // const double exam1 = .15;
           // const double exam2 = .25;
           // const double exam3 = .25;

            sum = (part * p) + (hmwrk * h) + (e1 * exam1) + (e2 * exam2) + (e3 * exam3);

            Console.WriteLine(fname + " " + lname + " " + "(" + studentid + ") " + "your final grade is " + sum.ToString("P"));

            Console.ReadKey();
            

        }
    }
}
