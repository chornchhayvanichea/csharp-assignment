namespace Assignment;

using Assignment.MiniCalculator;
using Assignment.MiniCalculator.CSVToJsonConverter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            " \n1.Remark Student\n"
                + "2.Sales With Discount\n"
                + "3.TacTacToe Game\n"
                + "4.CSV To Json Converter\n"
                + "5.\n"
                + "6.\n"
                + "7.\n"
                + "8.Calculator(Sum,Subtract,Multiply,Divide)\n"
                + "9.Minibank (Interest Rate)\n"
                + "10.Eletric Fee\n"
                + "Enter Function from 1-10:"
        );
        switch (int.Parse(Console.ReadLine()!))
        {
            case 1:
                Console.WriteLine("Enter Score: ");
                decimal Score = decimal.Parse(Console.ReadLine()!);
                var (Grade, Mention) = StudentRemark.GetMark(Score);
                Console.WriteLine($"Score: {Score}\nGrade: {Grade}\nMention: {Mention}");
                break;

            case 2:
                Console.WriteLine("Enter Amount: ");
                decimal Amount = decimal.Parse(Console.ReadLine()!);
                decimal Percentage = SaleWithDiscount.GetDiscountPercentage(Amount);
                if (Percentage == -1)
                {
                    Console.WriteLine("cannot be lower than 1");
                    return;
                }
                decimal DiscountAmount = SaleWithDiscount.DiscountAmount(Amount, Percentage);
                decimal AfterDiscount = SaleWithDiscount.FinalAmount(Amount, DiscountAmount);
                Console.WriteLine(
                    $"Amount: {Amount}\nPercentage: {Percentage}\nDiscount Amount: {DiscountAmount}\nAfter Discount: {AfterDiscount}"
                );
                break;

            case 3:
                TicTacToe.Start();
                break;

            case 4:
                CSVToJsonConverter.Start();
                break;

            case 5:
                GuessNumber.Game();
                break;

            case 6:
                break;

            case 7:
                break;

            case 8:
                double n1,
                    n2;
                Console.WriteLine("Welcome to Arithmetic Calculator\nEnter Operator(+,-,*,/)");
                switch (char.Parse(Console.ReadLine()!))
                {
                    case '+':
                        Console.WriteLine("Enter  Number1: ");
                        n1 = double.Parse(Console.ReadLine()!);
                        Console.WriteLine("Enter  Number2: ");
                        n2 = double.Parse(Console.ReadLine()!);
                        Console.WriteLine($"Result: {ArithmeticFunctions.Sum(n1, n2)}");
                        break;
                    case '-':
                        Console.WriteLine("Enter  Number1: ");
                        n1 = double.Parse(Console.ReadLine()!);
                        Console.WriteLine("Enter  Number2: ");
                        n2 = double.Parse(Console.ReadLine()!);
                        Console.WriteLine($"Result: {ArithmeticFunctions.Subtract(n1, n2)}");
                        break;
                    case '*':
                        Console.WriteLine("Enter  Number1: ");
                        n1 = double.Parse(Console.ReadLine()!);
                        Console.WriteLine("Enter  Number2: ");
                        n2 = double.Parse(Console.ReadLine()!);
                        Console.WriteLine($"Result: {ArithmeticFunctions.Multiply(n1, n2)}");
                        break;
                    case '/':
                        Console.WriteLine("Enter  Number1: ");
                        n1 = double.Parse(Console.ReadLine()!);
                        Console.WriteLine("Enter  Number2: ");
                        n2 = double.Parse(Console.ReadLine()!);
                        Console.WriteLine($"Result: {ArithmeticFunctions.Divide(n1, n2)}");
                        break;
                    default:
                        Console.WriteLine("Invalid Operator");
                        break;
                }
                break;
            case 9:
                Minibank bank = new Minibank(0, 0);
                Console.WriteLine("Enter Balance: ");
                bank.Balance = decimal.Parse(Console.ReadLine()!);
                bank.InterestRate = decimal.Parse(Console.ReadLine()!);
                Console.WriteLine(
                    $"Bank Account\nBalance:{bank.Balance}\nInterestRate:{bank.InterestRate}"
                );
                break;
            case 10:
                Console.WriteLine("Enter KWH: ");
                double kwh = double.Parse(Console.ReadLine()!);
                Console.WriteLine($"Kwh: {kwh}\nTotal: {ElectricFee.CalculateFee(kwh)}");
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
}
