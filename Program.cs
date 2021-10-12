using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int mult = 1;
            double avg = 0.0;
            for(int i= 0; i<5; i++)
            {
                Console.Write("Please enter a number: ");
                int smt = Convert.ToInt32(Console.ReadLine());
                sum += smt;
                mult = smt* mult;
            }
            avg= sum/5;
            Console.WriteLine($"Nums AVG = {avg}\nNums SUM = {sum}\nNums multiplied = {mult}");

            
        }

    }
}
