using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Letter_Frequency
    {
        ////Method: Letters
        //Arguments: String
        //Returns: List of Integers
        //Handles calculating number of each letter in a text
        public List<int> Letters(string input)
        {
            //Letters list that will be outputted
            List<int> Letters = new List<int>();
            //List of Letters
            List<string> alphabet = new List<string>()
            { 
              "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
              "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" 
            };
            //asigns all values of letters to 0
            for (int i = 0; i < 26; i++)
            {
                Letters.Add(0);
            }

            //looks at every character in the string
            for (int i = 0; i < input.Length; i++)
            { 
                //compares it to each letter and increments the corresponding value in Letters by 1
                for (int j = 0; j < alphabet.Count; j++)
                {
                    if (alphabet[j] == input[i].ToString())
                    {
                        Letters[j]++;
                    }
                }
            }
            //Output
            return Letters;
        }
    }
}
