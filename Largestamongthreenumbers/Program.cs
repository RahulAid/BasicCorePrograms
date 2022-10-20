namespace Largestamongthreenumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int Largest = 0;
            if (a > b && a > c)
                Largest = a;
            else if (b > a && b > c)
                Largest = b;
            else
                Largest = c;

            Console.WriteLine("Largest among "+ a +" , "+b+" and " +c+ " is : " + Largest);
            
        }
    }
}