namespace Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            float userInput = float.Parse(Console.ReadLine());

            double result = Math.Cos(userInput);
            Console.WriteLine(result);

        }
    }
}
