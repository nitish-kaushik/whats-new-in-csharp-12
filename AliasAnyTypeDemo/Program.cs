namespace AliasAnyTypeDemo
{
    //using TempE = Employee;
    //using TestAtt = int[,];

    internal class Program
    {
        static void Main(string[] args)
        {
            (int X, int Y) myPoint = (X: 10, Y: 20);

            Console.WriteLine($"{myPoint.X} {myPoint.Y}");
        }
    }
}
