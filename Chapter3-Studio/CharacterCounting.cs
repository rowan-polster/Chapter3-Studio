using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3_Studio
{
    public class CharacterCounting
    {
        public void findChars(char[] array) 
        {
            var characters = new List<char>();

            foreach (char c in array)
            {
                if (!characters.Contains(c))
                {
                    characters.Add(c);
                }
            }
            
            foreach(char character in characters)
            {
                Console.WriteLine(character);
            }
        }

        public void numberOfChars(string sentence)
        {
            var charCounts = new List<int>();

            for (int i = 0; i < sentence.Length; i++)
            {
                int count = sentence.ToLower().Split(sentence[i]).Length - 1;

                if (!charCounts.Contains(count))
                {
                    charCounts.Add(count);
                }
            }

            foreach (int charCount in charCounts)
            {
                Console.WriteLine(charCount);
            }
        }
    }
}
