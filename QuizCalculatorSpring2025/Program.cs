// written by Emilynn Molesky 
// 1/27/2025
namespace QuizCalculatorSpring2025
{
    public class Program
    {
        public static void Main(string[] args) // static means you dont need an instance for the varible main 
        {
            QuizCalculator aQuizCalculator = new QuizCalculator();

            aQuizCalculator.Quiz1 = 80.0;
            aQuizCalculator.Quiz2 = 85.0;
            aQuizCalculator.Quiz3 = 90.0;
            aQuizCalculator.Quiz4 = 85.0;

            Console.WriteLine("Total:" + aQuizCalculator.CalcTotal());
            Console.WriteLine("Total:" + aQuizCalculator.CalcAverage());
            Console.WriteLine("Total:" + aQuizCalculator.CalcLetterGrade());







        }
    }
}
