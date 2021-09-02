using System;

namespace _c__
{
    class Program
    {
        static void Main(string[] args)
        {
            Book best = new Book("Shingeki no Kyojin", 420, "Hajime Isayama", 1);
            Console.WriteLine(best.explaination());
            Book bruh = new Book("Naruto Shonin", 69, "Random idiot", 69);
            Console.WriteLine(bruh.explaination());
            Pages p = new Pages("Bruh", "bruh", 69, 420);
            Console.WriteLine(p.explaination());
            Console.ReadLine();
            
        }

        public static float sum(float a, float b){
            return (float) a+b;
        }
    }
}
