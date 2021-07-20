using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter3_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "this is a practice sentence";
            char[] charactersInString = sentence.ToLower().ToCharArray(); 
            var dictionary = new Dictionary<char, int>();

            { 

                for (int i = 0; i < charactersInString.Length; i++)
                {

                    int count = sentence.Split(sentence[i]).Length;
                    char characters = charactersInString[i];

                    if (!dictionary.ContainsKey(characters) && !dictionary.ContainsValue(count -1))
                    {
                        dictionary.Add(characters, count -1);
                    }



                }

                foreach(char character in charactersInString)
                {
                    int count = sentence.ToLower().Split(character).Length;
                    if (!dictionary.ContainsKey(character))
                    {
                        dictionary.Add(character, count);
                    }
                }

                foreach(var pair in dictionary)
                {
                    Console.WriteLine("KEY {0} VALUE {1}", pair.Key, pair.Value);
                }







            }

        }
    }
}

