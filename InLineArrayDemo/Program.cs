namespace InLineArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var buffer = new Buffer();
            for (int i = 0; i < 10; i++)
            {
                buffer[i] = i;
            }

            foreach (var i in buffer)
            {
                Console.WriteLine(i);
            }
        }
    }
}
