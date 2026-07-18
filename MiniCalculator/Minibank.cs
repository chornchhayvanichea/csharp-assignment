namespace Assignment.MiniCalculator
{
    public class Minibank
    {
        public decimal Balance { set; get; }
        public decimal InterestRate { set; get; }

        public Minibank(decimal b, decimal ir)
        {
            Balance = b;
            InterestRate = ir;
        }

        public decimal CalculateInterest() => Balance * (InterestRate / 100);
    }
}
