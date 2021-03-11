using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        private static Dictionary<string,int> FindWords(string line)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            string word = "";
            foreach (char letter in line)
            {
                int asciiLetter = (int)letter;
                if ((asciiLetter > 64 && asciiLetter < 91) || (asciiLetter > 96 && asciiLetter < 123)
                    || (asciiLetter > 1039 && asciiLetter < 1103) || asciiLetter == 1025 || asciiLetter == 1105)
                {
                    word += letter;
                }
                else
                {
                    word = word.ToLower();
                    if (words.Keys.Contains(word)) words[word] += 1;
                    else words.Add(word, 1);
                    word = "";
                }
            }
            return words;
        }
    }
}
