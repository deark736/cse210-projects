using System;

namespace Fractions
{
    public class Fraction
    {
        // Private attributes for the numerator and denominator.
        private int _top;
        private int _bottom;

        // No-argument constructor: initializes to 1/1.
        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        // One-parameter constructor: sets the numerator and defaults the denominator to 1.
        public Fraction(int top)
        {
            _top = top;
            _bottom = 1;
        }

        // Two-parameter constructor: sets both the numerator and denominator.
        public Fraction(int top, int bottom)
        {
            if (bottom == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            _top = top;
            _bottom = bottom;
        }

        // Getter for the numerator.
        public int GetTop()
        {
            return _top;
        }

        // Setter for the numerator.
        public void SetTop(int top)
        {
            _top = top;
        }

        // Getter for the denominator.
        public int GetBottom()
        {
            return _bottom;
        }

        // Setter for the denominator.
        public void SetBottom(int bottom)
        {
            if (bottom == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            _bottom = bottom;
        }

        // Returns the fraction in the form "numerator/denominator".
        public string GetFractionString()
        {
            return $"{_top}/{_bottom}";
        }

        // Returns the decimal value of the fraction.
        public double GetDecimalValue()
        {
            return (double)_top / _bottom;
        }
    }
}
