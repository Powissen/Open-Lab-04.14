using System;
using System.Linq;


namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            int longest = strings.Max(w => w.Length);
            string stars = new String('*', longest + 4);
            Console.WriteLine(stars);

            foreach (string word in strings)
            {
                int wordLenght = word.Length;

                int SpaceChar = longest - word.Length; 
                string space = new String(' ', SpaceChar);

                Console.WriteLine("* " + word + space + " *");
            }
            Console.WriteLine(stars);
        }
    }
}