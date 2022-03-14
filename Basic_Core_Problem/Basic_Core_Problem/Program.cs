using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    class BasicCoreProgram
    {
        public void FlipCoin()
        {
            int Head = 0;
            int Tail = 0;
            Console.WriteLine("Enter the Number of times you want flip coin: ");
            int Number_Of_Flip = Convert.ToInt32(Console.ReadLine());

            while (Number_Of_Flip <= 0)
            {
                Console.WriteLine("Invalid Input: Please input a number is greater than 0 ");
                Console.WriteLine("Please Enter again Number: ");
                Number_Of_Flip = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < Number_Of_Flip; i++)
            {
                Random flip = new Random();
                int Coin = flip.Next(0, 2);

                if (Coin < 0.5)
                {
                    Head++;
                }
                else
                {
                    Tail++;
                }
            }

            float Head_Percent = (float)Head * 100 / Number_Of_Flip;
            float Tail_Percent = (float)Tail * 100 / Number_Of_Flip;

            Console.WriteLine("Percentage of Head: " + Head_Percent);
            Console.WriteLine("Percentage of Tail: " + Tail_Percent);

        }
        public void YearLeap()
        {
            int Year;
            Console.WriteLine("Enter a Year: ");
            Year = int.Parse(Console.ReadLine());
            if (Year % 4 == 0 && Year % 100 != 0 || Year % 400 == 0)
            {
                Console.WriteLine("It is a Leap Year");
            }
            else
            {
                Console.WriteLine("It is not a Leap Year");
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for relative problem.\n");
            Console.WriteLine("1 For Flip Coin Percentage");
            Console.WriteLine("2 for Leap Year");
            int Problem = Convert.ToInt32(Console.ReadLine());
            BasicCoreProgram basicCoreProgram = new BasicCoreProgram();

            switch (Problem)
            {
                case 1:
                    basicCoreProgram.FlipCoin();
                    break;
                case 2:
                    basicCoreProgram.YearLeap();
                    break;
                default:
                    Console.WriteLine("You Enter Invalid Number ");
                    break;

            }
        }
    }
}
