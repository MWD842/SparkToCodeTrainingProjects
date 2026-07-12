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

            DateTime startSubscription = DateTime.Now;
            DateTime endSubscription = startSubscription.AddDays(30);
            Console.WriteLine("Your subscription ends on: "+endSubscription);

        }
    }
}
