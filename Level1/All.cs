using System;

namespace CgTraining2.Level1
{
    public class All
    {
        public static void HarryAge()
        {
            int birthYear = 2000;
            int currentYear = 2024;
            int age = currentYear - birthYear;
            Console.WriteLine($"Harry's age in 2024 is {age}");
        }

        public static void AveragePCM()
        {
            int maths = 94, physics = 95, chemistry = 96;
            double avg = (maths + physics + chemistry) / 3.0;
            Console.WriteLine($"Sam’s average mark in PCM is {avg}");
        }

        public static void KmToMilesFixed()
        {
            double km = 10.8;
            double miles = km * 1.6;
            Console.WriteLine($"The distance {km} km in miles is {miles}");
        }

        public static void ProfitAndLoss()
        {
            double cp = 129, sp = 191;
            double profit = sp - cp;
            double percent = (profit / cp) * 100;
            Console.WriteLine($"The Cost Price is INR {cp} and Selling Price is INR {sp}\nThe Profit is INR {profit} and the Profit Percentage is {percent}");
        }

        public static void DividePens()
        {
            int pens = 14, students = 3;
            Console.WriteLine($"The Pen Per Student is {pens / students} and the remaining pen not distributed is {pens % students}");
        }

        public static void DiscountedFeeFixed()
        {
            double fee = 125000, discountPercent = 10;
            double discount = fee * discountPercent / 100;
            Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {fee - discount}");
        }

        public static void EarthVolume()
        {
            double rKm = 6378;
            double volumeKm = (4.0 / 3.0) * Math.PI * Math.Pow(rKm, 3);
            double volumeMiles = volumeKm * 0.239913;
            Console.WriteLine($"The volume of earth in cubic kilometers is {volumeKm} and cubic miles is {volumeMiles}");
        }

        public static void KmToMilesUser()
        {
            Console.Write("Enter km: ");
            double km = Convert.ToDouble(Console.ReadLine());
            double miles = km / 1.6;
            Console.WriteLine($"The total miles is {miles} mile for the given {km} km");
        }

        public static void DiscountedFeeUser()
        {
            Console.Write("Enter fee: ");
            double fee = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter discount percent: ");
            double discountPercent = Convert.ToDouble(Console.ReadLine());
            double discount = fee * discountPercent / 100;
            Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {fee - discount}");
        }

        public static void HeightConversion()
        {
            Console.Write("Enter height in cm: ");
            double cm = Convert.ToDouble(Console.ReadLine());
            double inches = cm / 2.54;
            int feet = (int)(inches / 12);
            inches = inches % 12;
            Console.WriteLine($"Your Height in cm is {cm} while in feet is {feet} and inches is {inches}");
        }

        public static void Calculator()
        {
            Console.Write("Enter number1: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number2: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The addition, subtraction, multiplication and division value of 2 numbers {n1} and {n2} is {n1 + n2},{n1 - n2},{n1 * n2},{n1 / n2}");
        }

        public static void TriangleArea()
        {
            Console.Write("Enter base: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double areaInches = 0.5 * b * h;
            double areaCm = areaInches * 6.4516;
            Console.WriteLine($"The area of triangle is {areaInches} square inches and {areaCm} square centimeters");
        }

        public static void SquareSide()
        {
            Console.Write("Enter perimeter: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The length of the side is {p / 4} whose perimeter is {p}");
        }

        public static void FeetToYardsMiles()
        {
            Console.Write("Enter distance in feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            double yards = feet / 3;
            double miles = yards / 1760;
            Console.WriteLine($"Distance in yards is {yards} and in miles is {miles}");
        }

        public static void TotalPrice()
        {
            Console.Write("Enter unit price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The total purchase price is INR {price * qty} if the quantity {qty} and unit price is INR {price}");
        }

        public static void Handshakes()
        {
            Console.Write("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The maximum number of handshakes is {(n * (n - 1)) / 2}");
        }
    }
}
