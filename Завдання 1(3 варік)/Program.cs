namespace Завдання_1_3_варік_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Input();
            rectangle.Output();
            Console.WriteLine();
            rectangle[0] = 10;
            Console.WriteLine($" We changed first number: {rectangle[0]}");
            Console.WriteLine($"Our second number: {rectangle[1]}");
            Console.WriteLine();
            rectangle.Output();
        }
    }
}
