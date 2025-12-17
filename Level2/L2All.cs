using System;

namespace CgTraining2.Level2
{
    public class L2All
    {
        public static void QuotientAndRemainder()
        {
            Console.Write("Enter first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n2 == 0) { Console.WriteLine("Division by zero not allowed.\n"); return; }
            Console.WriteLine($"The Quotient is {n1 / n2} and Remainder is {n1 % n2} when {n1} is divided by {n2}\n");
        }

        public static void PerformIntOperations()
        {
            Console.Write("Enter a: "); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: "); int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c: "); int c = Convert.ToInt32(Console.ReadLine());
            int op1 = a + b * c;
            int op2 = a * b + c;
            int op3 = c + a / b;
            int op4 = a % b + c;
            Console.WriteLine($"The results of Int Operations are {op1}, {op2}, {op3}, {op4}\n");
        }

        public static void PerformDoubleOperations()
        {
            Console.Write("Enter a: "); double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter b: "); double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter c: "); double c = Convert.ToDouble(Console.ReadLine());
            double op1 = a + b * c;
            double op2 = a * b + c;
            double op3 = c + a / b;
            double op4 = a % b + c;
            Console.WriteLine($"The results of Double Operations are {op1}, {op2}, {op3}, {op4}\n");
        }

        public static void CelsiusToFahrenheit()
        {
            Console.Write("Enter Celsius: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = (c * 9.0 / 5.0) + 32;
            Console.WriteLine($"The {c} Celsius is {f:F2} Fahrenheit\n");
        }

        public static void FahrenheitToCelsius()
        {
            Console.Write("Enter Fahrenheit: ");
            double f = Convert.ToDouble(Console.ReadLine());
            double c = (f - 32) * 5.0 / 9.0;
            Console.WriteLine($"The {f} Fahrenheit is {c:F2} Celsius\n");
        }

        public static void CalculateIncome()
        {
            Console.Write("Enter salary (INR): ");
            double s = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter bonus (INR): ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The salary is INR {s} and bonus is INR {b}. Hence Total Income is INR {s + b}\n");
        }

        public static void SwapNumbers()
        {
            Console.Write("Enter first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int t = n1; n1 = n2; n2 = t;
            Console.WriteLine($"The swapped numbers are {n1} and {n2}\n");
        }

        public static void ShowTrip()
        {
            Console.Write("Name: "); string name = Console.ReadLine();
            Console.Write("From city: "); string from = Console.ReadLine();
            Console.Write("Via city: "); string via = Console.ReadLine();
            Console.Write("To city: "); string to = Console.ReadLine();
            Console.Write("Distance from-to-via (miles): "); double d1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Distance via-to-final (miles): "); double d2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Time taken (hours): "); double time = Convert.ToDouble(Console.ReadLine());
            double total = d1 + d2;
            double speed = total / time;
            Console.WriteLine($"\nHello {name}!!");
            Console.WriteLine($"Journey: {from} → {via} → {to}");
            Console.WriteLine($"Total distance: {total} miles");
            Console.WriteLine($"Time taken: {time} hours");
            Console.WriteLine($"Average speed: {speed:F2} mph\n");
        }

        public static void CalculateRounds()
        {
            Console.Write("Side 1 (m): "); double s1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side 2 (m): "); double s2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side 3 (m): "); double s3 = Convert.ToDouble(Console.ReadLine());
            double peri = s1 + s2 + s3;
            double rounds = 5000 / peri;
            Console.WriteLine($"The total number of rounds the athlete will run is {Math.Ceiling(rounds)} to complete 5 km\n");
        }

        public static void DistributeChocolates()
        {
            Console.Write("Number of chocolates: "); int ch = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of children: "); int kids = Convert.ToInt32(Console.ReadLine());
            if (kids == 0) { Console.WriteLine("Cannot divide by zero.\n"); return; }
            Console.WriteLine($"The number of chocolates each child gets is {ch / kids} and the number of remaining chocolates is {ch % kids}\n");
        }

        public static void CalculateSimpleInterest()
        {
            Console.Write("Principal: "); double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Rate (%): "); double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Time (years): "); double t = Convert.ToDouble(Console.ReadLine());
            double si = (p * r * t) / 100;
            Console.WriteLine($"The Simple Interest is {si:F2} for Principal {p}, Rate of Interest {r} and Time {t}\n");
        }

        public static void ConvertPoundsToKg()
        {
            Console.Write("Weight in pounds: ");
            double lb = Convert.ToDouble(Console.ReadLine());
            double kg = lb / 2.2;
            Console.WriteLine($"The weight of the person in pounds is {lb} and in kg is {kg:F3}\n");
        }
    }
}