using System.Security.Cryptography.X509Certificates;

namespace Coinflip
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            double tailcount = 0;
            double headcount = 0;
            Console.WriteLine("Enter the no. of times to flip a coin");
            int loopCount = Convert.ToInt32(Console.ReadLine());
            int loop = loopCount;
            int i = 1;
            
                while (i <= loop)
                {
                    Random random = new Random();
                    double coinflip = random.Next(0, 2);

                    if (coinflip < 0.5)
                    {
                        tailcount++;
                    }
                    else
                    {
                        headcount++;
                    }
                    i++;

                    
                }
                double Tailpercentage = (tailcount / loop) * 100;
                double Headpercentage = (headcount / loop) * 100;

                Console.WriteLine("The occurence percentage of heads is: " + Headpercentage + " % ");
                Console.WriteLine("The occurence percentage of tails is: " + Tailpercentage + " % ");
                Console.ReadLine();

            
        }
    }
}