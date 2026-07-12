using System.Data;

namespace Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //built-in functions call 
            // className.functionName(parameters)

            //Math.Cos(90);
            //Math.Pow(2, 3);    // 2^3 = 8
            //Console.WriteLine("hello");
            //Console.Clear();

            //double r = Math.Cos(90);
            //Console.WriteLine(r); 

            //Console.WriteLine(Math.Pow(2, 3));

            /////////////////

            //Console.WriteLine("Enter a number: ");
            //float userInput = float.Parse(Console.ReadLine());

            //double result = Math.Cos(userInput);
            //Console.WriteLine(result);

            /////////////////

            //Console.WriteLine("Enter base number: ");
            //float baseNumber = float.Parse(Console.ReadLine());
            //Console.WriteLine("Enter power number: ");
            //float powerNumber = float.Parse(Console.ReadLine());
            //double result1= Math.Pow(baseNumber, powerNumber);
            //Console.WriteLine(result1);

            /////////////////

            //DateTime currentTiming = DateTime.Now; 
            //Console.WriteLine(currentTiming);

            //DateTime timing = DateTime.Today;
            //Console.WriteLine(timing);

            //DateTime startSubscription = DateTime.Now;
            //DateTime endSubscription = startSubscription.AddDays(30);
            //Console.WriteLine("Your subscription ends on: "+endSubscription);

            /////////////////

            // string function call
            // stringName.functionName(parameters)
            //string word = "Hello, World";
            //int length = word.Length;
            //string sublength = word.Substring(7, 5);
            //string upperedWord = word.ToUpper();
            //string loweredWord = word.ToLower();

            //Console.WriteLine("Length: " + length + "\nSublength: " + sublength);
            //Console.WriteLine("Uppercase: " + upperedWord + "\nLowercase: " + loweredWord);
            // a is diffenet from A
            // ahmed is equal to AHMED is equal to Ahmed

            string name = "Ahmed";
            Console.WriteLine("Enter your name: ");
            string input = Console.ReadLine();
            if (input.ToUpper() == name.ToUpper())
            {
                Console.WriteLine("Welcome to application, successfull signed on");
            }
            else
            {
                Console.WriteLine("Invalid name, please try again");
            }

            
        }

    }
}
