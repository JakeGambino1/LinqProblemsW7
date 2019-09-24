using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using LINQ, write function that returns all words containing "th"
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            // Using LINQ, write a function that takes in a list of strings and returns copy without duplicates
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            // write a function that:
            // drops lowest grade
            // averages the list
            // averages those averages
            // expected output = 86.125
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };

            var wordsWithTh = words.Where(w => w.Contains("th"));
            foreach(var word in wordsWithTh)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();


            var namesNoDuplicates = names.Distinct();
            foreach (var noDuplicate in namesNoDuplicates)
            {
                Console.WriteLine(noDuplicate);
            }
            Console.ReadLine();



        }
    }
}
