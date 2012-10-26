using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            










            //Line[] Lines = {new Line(new String[]{"eating", "carrots,", "but", "enjoy" ,"Horses"}, 1),
            //                new Line(new String[]{"zebras?", "hay", "Cows", "bridge.", "bolted"}, 2),
            //                new Line(new String[]{"fork", "dogs!", "Engine", "and"}, 3),
            //                new Line(new String[]{"love", "they", "apples.", "eating"}, 2),
            //                new Line(new String[]{"whistled.", "Bump"}, 1)
            //               };

            //var words = from line in Lines
            //            group line by line.Value
            //                into wordGroups
            //                orderby wordGroups.Key
            //                select wordGroups;

            //var twoGroups = words.Take(2);

            //foreach (var group in twoGroups)
            //{
            //    int i = 0;
            //    foreach (var inner in group)
            //    {
            //        i++;
            //        if (i == group.Key)
            //        {
            //            var poem = from word in inner.Words
            //                       orderby word descending
            //                       select word + " ";

            //            foreach (var word in poem)
            //                Console.WriteLine(word);
            //        }
            //    }
            //}



            Console.ReadLine();
        }
    }

    public class Line
    {
        public String[] Words;
        public Int32 Value;

        public Line(String[] Words, Int32 Value)
        {
            this.Words = Words;
            this.Value = Value;
        }
    }

    public class Purchase
    {
        public Int32 Issue { get; set; }
        public Int32 Price { get; set; }

        
    }
}
