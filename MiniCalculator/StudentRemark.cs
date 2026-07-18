namespace Assignment.MiniCalculator
{
    public class StudentRemark
    {
        public static (string grade, string mention) GetMark(decimal score)
        {
            if (score >= 85 && score <= 100)
                return ("A", "Excellent");
            else if (score >= 80 && score <= 84)
                return ("B+", "Very Good");
            else if (score >= 70 && score <= 79)
                return ("B", "Good");
            else if (score >= 65 && score <= 69)
                return ("C+", "Fairly Good");
            else if (score >= 50 && score <= 64)
                return ("C", "Fair");
            else if (score >= 45 && score <= 49)
                return ("D", "Poor");
            else if (score >= 40 && score <= 44)
                return ("E", "Very Poor");
            else if (score < 40)
                return ("F", "Failure");
            else
                return ("Invalid", "Invalid Input");
        }
    }
}
