using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter3_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is a practice sentence";

            //Console.WriteLine("Please enter a sentence for character-counting:\n");

            //string inputSentence = Console.ReadLine();
            
            {

                var charactersInString = new CharacterCounting();

                charactersInString.findChars(sentence);

              






            }

        }
    }
}

