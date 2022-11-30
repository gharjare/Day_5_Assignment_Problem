using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class FlipCoin
    {
        public static void Display()
        {
            int headcount = 0;
            int tailcount = 0;
            double headpercentage = 0;
            double tailpercentage = 0;

            Console.WriteLine("Enter the number of flip");
            int numofflip = Convert.ToInt32(Console.ReadLine());

            if(numofflip > 0)
            {
                for(int i = 0; i < numofflip; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine(number);

                    if(number == 0)
                    {
                        tailcount++;
                    }
                    else
                    {
                        headcount++;
                    }
                }
                headpercentage = headcount * 100 / numofflip;
                tailpercentage = tailcount * 100 / numofflip;

                Console.WriteLine("headpercentage" + tailpercentage);
                Console.WriteLine("tailpercentage" + headpercentage);





            }
            

        }
    }
}
