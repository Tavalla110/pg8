using System;

namespace pg8
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Plese enter value of balanc to Toman:");
            string str1 = Console.ReadLine();
            Console.WriteLine("please enter number of years:");
            string str2 = Console.ReadLine();
            double val = Convert.ToDouble(str1);
            int year = Convert.ToInt32(str2);
            calculate(val,year);
        }
        private static double calculate(double interest, int y)
        { 
            double interestbalance = ((interest * 18) / 100); 
            double finalbalance = (interestbalance * y)+ interest;
            Console.WriteLine(interestbalance + " :Toman 18% interest after 1 year ");
            Console.WriteLine("Total balance after " + y + " years is: " + finalbalance );
            return interestbalance;
        }
    }
}
