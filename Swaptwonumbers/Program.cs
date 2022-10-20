namespace Swaptwonumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Initial value of a is :" + a);
            Console.WriteLine("Initial value of b is :" + b);
            
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("------------ After Swapping ---------------");

            Console.WriteLine("New value of a is :" + a);
            Console.WriteLine("New value of b is :" + b);

        }
    }
}