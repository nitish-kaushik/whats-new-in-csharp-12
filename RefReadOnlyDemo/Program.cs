namespace RefReadOnlyDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 10;

            DisplayValue(myNumber);
            Console.WriteLine(myNumber);
        }

        static void DisplayValue(int number)
        {
            Console.WriteLine($"Value: {number}");
            number++;
        }
    }
}
