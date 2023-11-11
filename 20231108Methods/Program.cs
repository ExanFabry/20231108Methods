namespace _20231108Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable for the answer to the question if they want to repeat the loop.
            string answer = "";

            //Loop to repeat the program.
            do
            {
                //Asking the user which method they want to use.
                Console.WriteLine("Which method do you want to select?");
                Console.WriteLine("1 - PositiveZeroNegative");
                Console.WriteLine("2 - ConvertToFahrenheit");
                Console.WriteLine("3 - NumberTriangle");
                int input = Convert.ToInt32(Console.ReadLine());

                //Selecting the right method
                switch(input)
                {
                    case 1:
                        Console.WriteLine("Give a number");
                        double number = Convert.ToDouble(Console.ReadLine());
                        PositiveZeroNegative(number);
                        Answer();
                        input = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Give a number");
                        double degreesCelsius = Convert.ToDouble(Console.ReadLine());
                        ConvertToFahrenheit(degreesCelsius);
                        Answer();
                        input = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Give a number");
                        int maximumNumber = Convert.ToInt32(Console.ReadLine());
                        NumberTriangle(maximumNumber);
                        Answer();
                        input = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        Answer();
                        input = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                //If answer is no repeat the loop.
            } while (answer.ToLower() != "no");
        }
        static string PositiveZeroNegative(double number)
        {
            if (number > 0){return "positive";}
            else if (number == 0){ return "zero";}
            else { return "negative"; }
        }
        static double ConvertToFahrenheit(double celsius) => celsius * 9 / 5 + 32;
        static void NumberTriangle(int maximumNumber)
        {
            //The loop is active while i is smaller and equal to maximumNumber.
            for (int i = 1; i <= maximumNumber; i++)
            {
                //The loop is active while j is smaller and equal to i.
                for (int j = 1; j <= i; j++)
                {
                    //Write j.
                    Console.Write(j);
                }
                //An empty Console.WriteLine() meant as an enter.
                Console.WriteLine();
            }
            //The loop is active while i is larger then maximumNumber.
            for (int i = maximumNumber - 1; i > 0; i--)
            {
                //The loop is active while j is smaller and equal to i.
                for (int j = 1; j <= i; j++)
                {
                    //Write j.
                    Console.Write(j);
                }
                //An empty Console.WriteLine() meant as an enter.
                Console.WriteLine();
            }
        }
        static string Answer() => "Do you want to restart the program?";
    }
}