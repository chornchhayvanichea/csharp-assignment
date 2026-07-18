namespace Assignment.MiniCalculator
{
    public class ElectricFee
    {
        public static double CalculateFee(double Kwh, double PricePerUnit = 750) =>
            Kwh * PricePerUnit;
    }
}
