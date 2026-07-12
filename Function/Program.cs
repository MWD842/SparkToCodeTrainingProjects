namespace Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //built-in functions call 
            // className.functionName(parameters)

            Math.Cos(90);
            Math.Pow(2, 3);    // 2^3 = 8
            Console.WriteLine("hello");
            Console.Clear();

            double r = Math.Cos(90);
            Console.WriteLine(r); 

            Console.WriteLine(Math.Pow(2, 3));

            /////////////////

            Console.WriteLine("Enter a number: ");
            float userInput = float.Parse(Console.ReadLine());

            double result = Math.Cos(userInput);
            Console.WriteLine(result);

            /////////////////
            

        }
    }
}
