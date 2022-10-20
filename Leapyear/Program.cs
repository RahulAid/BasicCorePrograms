namespace Leapyear
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a four digit number");
            int num = Convert.ToInt32(Console.ReadLine());
            
            //int count = 0;

            //while ( num != 0 )
            //{
            //num /= 10 ;
            //    count++ ;
            //}
            //if ( count == 4 )
            //{
            if (((num % 4 == 0) && (num % 100 != 0)) || (num % 400 == 0))
            {
                Console.WriteLine(+num+ " is a Leap Year ");

            }
            else
            {
                Console.WriteLine(+num+ " is not a Leap Year");
            }
            //}
            //else
            //{
            // Console.WriteLine("The entered number is not a Four digit number");
            //}

            Console.ReadLine();
        }
    }
}