using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WordSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = "digital";
            int total = 0;
            int size = 0;

            var threeLetters = word.Select(x => x.ToString());
            size = 2;
            for (int i = 0; i < size; i++)
            {
                threeLetters = threeLetters.SelectMany(x => word, (x, y) => x + y);
            }
            foreach (var item in threeLetters)
            {
                Console.WriteLine(item);
                total++;
            }

            var fourLetters = word.Select(x => x.ToString());
            size = 3;
            for (int i = 0; i < size; i++)
            {
                fourLetters = fourLetters.SelectMany(x => word, (x, y) => x + y);
            }
            foreach (var item in fourLetters)
            {
                Console.WriteLine(item);
                total++;
            }

            var fiveLetters = word.Select(x => x.ToString());
            size = 4;
            for (int i = 0; i < size; i++)
            {
                fiveLetters = fiveLetters.SelectMany(x => word, (x, y) => x + y);
            }
            foreach (var item in fiveLetters)
            {
                Console.WriteLine(item);
                total++;
            }

            var sixLetters = word.Select(x => x.ToString());
            size = 5;
            for (int i = 0; i < size; i++)
            {
                sixLetters = sixLetters.SelectMany(x => word, (x, y) => x + y);
            }
            foreach (var item in sixLetters)
            {
                Console.WriteLine(item);
                total++;

            }

            var sevenLetters = word.Select(x => x.ToString());
            size = 6;
            for (int i = 0; i < size; i++)
            {
                sevenLetters = sevenLetters.SelectMany(x => word, (x, y) => x + y);
            }
            foreach (var item in sevenLetters)
            {
                Console.WriteLine(item);
                total++;
            }

            Console.WriteLine(total);
        }
    }
}
