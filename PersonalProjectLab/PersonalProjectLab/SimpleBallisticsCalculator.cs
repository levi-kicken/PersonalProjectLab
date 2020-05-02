using System;
namespace PersonalProjectLab
{
    public class SimpleBallisticsCalculator
    {
        public SimpleBallisticsCalculator()
        { 
        }
        public decimal CalculateAverageMuzzleVelocity(int velocity1, int velocity2, int velocity3)
        {
            //muzzle velocity = sum of velocities/number of velocities
            decimal avg = 0.00m;

            avg = (velocity1 + velocity2 + velocity3)/3;

            Math.Round(avg, 2);

            return avg;
        }

        public decimal CalculateMuzzleAngle(decimal velocity, decimal distance)
        {
            //Muzzle angle = 1/2arcsin[(g*x)/v^2]
            decimal muzzleAngle = 0.00m;
            double muzzleDegrees = 0.00;
            double muzzleRadians = 0.00;
            decimal gravity = 9.81m;
            decimal sinTop = 0.000m;
            decimal sinBottom = 0.000m;
            decimal sinFunction = 0.000m;
            double radianConverter = 57.2958;


            sinTop = Decimal.Multiply(gravity, distance);

            sinBottom = Decimal.Multiply(velocity, velocity);

            sinFunction = sinTop / sinBottom;

            double sinValue = Decimal.ToDouble(sinFunction);

            muzzleRadians = 0.5 * Math.Asin(sinValue);

            muzzleDegrees = muzzleRadians * radianConverter;

            muzzleAngle = Convert.ToDecimal(muzzleDegrees);

            muzzleAngle = Math.Round(muzzleAngle, 2);

            return muzzleAngle;
        }
    }
}
