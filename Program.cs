using System;
using System.Collections.Generic;

namespace Bakery
{
    public class Bread
    {
        public int Count;

        public Bread(int count)
        {
            Count = count;
        }

        public int CalculateTotalPrice()
        {
            return Count / 3 * 10  + Count % 3 * 5;
        }
    }

    public class Pastry
    {
        public int Count;

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
//            Bread rye = new Bread ("rye",5);
//            Bread white = new Bread ("white",5);
//            Bread german = new Bread ("german",5);
//            Bread sordough = new Bread ("sordough",5);

      
//            List<Bread> Breads = new List<Bread>(){rye,white,german, sordough};

            
            Console.WriteLine ("Welcome to our Bakery. We have a wide variety of bread and pastry.");
            Console.WriteLine ("One loaf is $5 and one item of pastry is $2. today's special Buy 2, get 1 free. A single loaf costs $5. Buy 1 for $2 or 3 for $5.");
            
//            Console.WriteLine ("Choose bread(rye, white, german, sordough, glutenfree) or pastry(apple turnover, croissant, upside down cake)");

            Console.WriteLine ("Enter count for bread");
            int countBread = int.Parse(Console.ReadLine());
            Console.WriteLine ("Enter count for pastry");
            int countPastry = int.Parse(Console.ReadLine());
            Bread bread = new Bread(countBread);
            Pastry pastry = new Pastry(countPastry);
            
            Console.WriteLine ("Total price is " + (bread.CalculateTotalPrice() + pastry.CalculateTotalPrice()));

            
        }
    }
}