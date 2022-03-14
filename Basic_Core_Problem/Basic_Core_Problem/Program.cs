﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    class FlipCoinPercentage
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
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for relative problem.\n");
            Console.WriteLine("1 For Flip Coin Percentage");

            int Problem = Convert.ToInt32(Console.ReadLine());

            switch (Problem)
            {
                case 1:
                    FlipCoinPercentage flipCoinPercentage = new FlipCoinPercentage();
                    flipCoinPercentage.FlipCoin();
                    break;
                default:
                    Console.WriteLine("You Enter Invalid Number ");
                    break;

            }
        }
    }
}