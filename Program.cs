using System;
using System.Collections.Generic;

namespace Bakery
{
    public class Bread
    {
        public int Count { get; set; }

        public Bread()
        {
            Count = 0;
        }

        public int CalculateTotalPrice()
        {
            return Count / 3 * 10  + Count % 3 * 5;
        }
    }

    public class Pastry
    {
        public int Count { get; set; }

        public Pastry(int count)
        {
            Count = count;
        }

        public int CalculateTotalPrice()
        {

            return Count / 3 * 5 + Count % 3 * 2;
        }
        
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("*                       *");
            Console.WriteLine("*    Pierre's Bakery    *");
            Console.WriteLine("*                       *");
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine ("Welcome to Pierre's Bakery. We have a wide variety of bread and pastry.");
            Console.WriteLine ("One loaf is $5 and one item of pastry is $2. Today's special Buy 2, get 1 free. A single loaf costs $5. Buy 1 for $2 or 3 for $5.");
            Console.WriteLine ("Enter count for bread:");
            int countBread = int.Parse(Console.ReadLine());
            Console.WriteLine ("Enter count for pastry");
            int countPastry = int.Parse(Console.ReadLine());
            Bread bread = new Bread();
            bread.Count = countBread;
            Pastry pastry = new Pastry(countPastry);
            
            Console.WriteLine ("Total price is " + (bread.CalculateTotalPrice() + pastry.CalculateTotalPrice()));

            
        }
    }
}