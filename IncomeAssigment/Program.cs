using System;

namespace IncomeAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("\n");
            Console.WriteLine("Person 1");
            Console.WriteLine("\n");

            Console.WriteLine("What is Person 1 Hourly rate?");
            string personOneHourly = Console.ReadLine();
            double personOneHourlyDouble = Convert.ToDouble(personOneHourly);

            Console.WriteLine("How many hours,per week, Person 1 works?");
            string personOneHous = Console.ReadLine();
            int personOneHoursInt = Convert.ToInt32(personOneHous);

            Console.WriteLine("What is Person 2 Hourly rate?");
            string personTwoHourly = Console.ReadLine();
            double personTwoHourlyDouble = Convert.ToDouble(personTwoHourly);

            Console.WriteLine("How many hours,per week, Person 2 works?");
            string personTwoHous = Console.ReadLine();
            int personTwoHoursInt = Convert.ToInt32(personTwoHous);

            double personOneAnnual = (personOneHourlyDouble * personOneHoursInt) * 52;
            double personTwoAnnual = (personTwoHourlyDouble * personTwoHoursInt) * 52;

            Console.WriteLine("Person 1 makes more money than Person 2 ");
            Console.WriteLine(personOneAnnual > personTwoAnnual ? "true" : "false");
            Console.ReadLine();

        }
    }
}
