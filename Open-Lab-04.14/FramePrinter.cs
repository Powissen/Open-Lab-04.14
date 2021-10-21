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
                string space = new String(' ', longest - word.Length);
                Console.WriteLine("* " + word + space + " *");
            }
            Console.WriteLine(stars);
        }
    }
}