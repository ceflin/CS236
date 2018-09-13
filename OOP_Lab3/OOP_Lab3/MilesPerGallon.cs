using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    class MilesPerGallon
    {
        private double _gallons;
        private double _miles;
        private double _mpg;

        public double Miles
        {
            get => _miles;
            set
            {
                ValidateNonNegative(value);
                ValidatNonZero(value);
                _miles = value;
            }
        }



        public double Gallons
        {
            get => _gallons;
            set
            {
                ValidateNonNegative(value);
                _gallons = value;
            }
        }

        public double Mpg => Miles / Gallons;

        private void ValidatNonZero(double value)
        {
            throw new ArgumentOutOfRangeException();
        }

        private void ValidateNonNegative(double value)
        {
            if (value < 0) throw NegativeNumberException();
        }
    }

}
