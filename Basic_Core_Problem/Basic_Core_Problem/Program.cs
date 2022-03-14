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

        public void PowerOf()
        {
            Console.WriteLine("Enter a Number ");
            int number = int.Parse(Console.ReadLine());
            if (number < 31)
            {
                int PowerOfTwo = (int)Math.Pow(2, number);
                Console.WriteLine("2 to the Power of: " + number);
                Console.WriteLine("=" + PowerOfTwo);
            }
            else
            {
                Console.WriteLine("Number must be less than 31");
            }

        }

        public double nthharmonic(int N)
        {
            float harmonic = 1;
            for (int i = 2; i <= N; i++)
            {
                harmonic += (float)1 / i;
            }
            return harmonic;

        }
        public void harmonic()
        {
            Console.WriteLine("Enter a N Value");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine(nthharmonic(N));
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for relative problem.\n");
            Console.WriteLine("1 For Flip Coin Percentage");
            Console.WriteLine("2 for Leap Year");
            Console.WriteLine("3 for Power of 2");
            Console.WriteLine("4 for Harmonic Number");
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
                case 3:
                    basicCoreProgram.PowerOf();
                    break;
                case 4:
                    basicCoreProgram.harmonic();
                    break;
                default:
                    Console.WriteLine("You Enter Invalid Number ");
                    break;

            }
        }
    }
}
