using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_pos_sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox box jumps over the lazy dog.";
            Console.WriteLine("Original string:"+sentence);
            Console.WriteLine("Position of the word 'lazy' in the said string:"+test(sentence,"lazy"));
        }
        public static int test(string text, string word)
        { return Array.IndexOf(text.Split(' '), word) + 1; }
    }
}
