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
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };

            // Number One
            var wordsWithTh = words.Where(w => w.Contains("th"));
            foreach(var word in wordsWithTh)
            {
                Console.WriteLine(word);
            }

            // Number Two
            var namesNoDuplicates = names.Distinct();
            foreach (var noDuplicate in namesNoDuplicates)
            {
                Console.WriteLine(noDuplicate);
            }

            // Number Three
            void AverageGrade(List<string> stringList)
            {
                var classGradesArr = new List<double>();
                double averageGrade = 0;
                List<double> averageGradeList = new List<double>();
                double totalGradeAverage;

                for (int i = 0; i < stringList.Count; i++)
                {
                    classGradesArr = classGrades[i].Split(',').Select(double.Parse).OrderBy(c => c).ToList();
                    classGradesArr.RemoveAt(0);
                    averageGrade = classGradesArr.Average();
                    averageGradeList.Add(averageGrade);
                }

                totalGradeAverage = averageGradeList.Average();
                Console.WriteLine($"{totalGradeAverage} is the class average");
            }
            AverageGrade(classGrades);
            // Write a function that takes in a string of letters (i.e. “Terrill”) and 
            // returns an alphabetically ordered string corresponding to the letter frequency 
            // (i.e. "E1I1L2R2T1")

            void AlphabeticStringReturn(string str)
            {
                StringBuilder sb = new StringBuilder();
                var strArray = str.ToCharArray().OrderBy(s => s).ToList();
                string stringAdd;

                for (int i = 0; i < strArray.Count; i++)
                {
                    int counter = 0;
                    while ((i + counter < strArray.Count) && 
                        strArray?[i] == strArray?[i + counter])
                    {
                        counter++;
                    }
                    stringAdd = $"{counter}{strArray[i]}";

                    if (sb.ToString().Contains($"{strArray[i]}"))
                    {
                        continue;
                    }
                    sb.Append(stringAdd);
                    counter = 0;
                }
                Console.WriteLine(sb);
                Console.ReadLine();
            }
            AlphabeticStringReturn("littttttle");

        }
    }
}
