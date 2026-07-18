namespace Assignment.MiniCalculator
{
    public class SaleWithDiscount
    {
        public static decimal GetDiscountPercentage(decimal amount)
        {
            if (amount < 1)
                return -1;
            if (amount <= 50)
                return 5;
            if (amount <= 100)
                return 10;
            if (amount <= 300)
                return 15;
            if (amount <= 600)
                return 20;
            if (amount <= 1000)
                return 25;
            if (amount <= 5000)
                return 30;
            if (amount <= 7000)
                return 40;
            return 45;
        }

        public static decimal DiscountAmount(decimal amount, decimal percentage)
        {
            decimal discount_amount = amount * percentage / 100;
            return discount_amount;
        }

        public static decimal FinalAmount(decimal amount, decimal discount_amount)
        {
            return amount - discount_amount;
        }
    }
}
