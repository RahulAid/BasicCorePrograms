namespace Quotientandremainder
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Dividend value : ");
            int Dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor value : ");
            int Divisor = Convert.ToInt32(Console.ReadLine());

            int Quotient = Dividend / Divisor;
            int Remainder = Dividend % Divisor;

            Console.WriteLine("The Quotient is : " + Quotient);
            Console.WriteLine("The Remainder is : " + Remainder);
            Console.ReadLine();
        }
    }
}