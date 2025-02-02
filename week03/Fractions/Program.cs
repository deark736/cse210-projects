using System;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a fraction using the no-argument constructor (should be 1/1).
            Fraction fraction1 = new Fraction();
            Console.WriteLine(fraction1.GetFractionString());  // Expected output: "1/1"
            Console.WriteLine(fraction1.GetDecimalValue());      // Expected output: 1

            // Create a fraction using the one-parameter constructor (e.g., 5 becomes 5/1).
            Fraction fraction2 = new Fraction(5);
            Console.WriteLine(fraction2.GetFractionString());  // Expected output: "5/1"
            Console.WriteLine(fraction2.GetDecimalValue());      // Expected output: 5

            // Create a fraction using the two-parameter constructor (e.g., 3/4).
            Fraction fraction3 = new Fraction(3, 4);
            Console.WriteLine(fraction3.GetFractionString());  // Expected output: "3/4"
            Console.WriteLine(fraction3.GetDecimalValue());      // Expected output: 0.75

            // Create another fraction using the two-parameter constructor (e.g., 1/3).
            Fraction fraction4 = new Fraction(1, 3);
            Console.WriteLine(fraction4.GetFractionString());  // Expected output: "1/3"
            Console.WriteLine(fraction4.GetDecimalValue());      // Expected output: approximately 0.3333333333333333

            // (Optional) Demonstrate getters and setters by modifying a fraction.
            fraction1.SetTop(2);
            fraction1.SetBottom(5);
            Console.WriteLine("After modifying fraction1:");
            Console.WriteLine(fraction1.GetFractionString());  // Expected output: "2/5"
            Console.WriteLine(fraction1.GetDecimalValue());      // Expected output: 0.4
        }
    }
}
