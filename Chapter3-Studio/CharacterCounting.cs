using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3_Studio
{
    public class CharacterCounting
    {
        public void findChars(string sentence)
        {
            char[] charactersInString = sentence.ToLower().ToCharArray();
            var dictionary = new Dictionary<char, int>();

            foreach (char character in charactersInString) 
            {
                int count = sentence.ToLower().Split(character).Length - 1;  
                if (!dictionary.ContainsKey(character))
                {
                    dictionary.Add(character, count);
                }
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }

    }
}

