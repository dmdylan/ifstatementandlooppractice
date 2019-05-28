using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Entries();
            
        }

        public static void Entries()
        {
            string enteredValue = Console.ReadLine();
            bool score1 = int.TryParse(enteredValue,out int score);
            int sum =0;
            int counter =0;
            double average;

            if (score1)
            {
                sum += score;
                counter++;
                Console.WriteLine("Please enter the next test score or enter -1 to calculate average:");
                if(Console.ReadLine()=="-1")
                {
                    average = sum/counter;
                    Console.WriteLine(average);
                }
            }
            else
            {
                Console.WriteLine("Please only enter numbers.");
            }
        }
    }
}
