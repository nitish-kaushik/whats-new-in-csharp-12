namespace DefaultLambdaDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var GetSquare = (int number) => number * number;

            Console.WriteLine(GetSquare(5));
        }
    }
}
