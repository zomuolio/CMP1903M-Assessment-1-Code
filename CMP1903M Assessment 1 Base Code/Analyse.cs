using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            // values list
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }


            //Case for sentences
            List<string> Sentence = new List<string>() { ".", "?", "!" };
            for (int i = 0; i < Sentence.Count; i++)
            {
                values[0] += input.Split(Sentence[i]).Count() - 1;
            }

            //creating lists for upper and lower case to save time on assigning values to them.
            List<string> Upper = new List<string>();
            List<string> Lower = new List<string>();

            //Case for vowels
            List<string> Vowel = new List<string> { "a", "e", "i", "o", "u" };
            for (int i = 0; i < Vowel.Count; i++)
            {
                values[1] += input.Split(Vowel[i]).Count() - 1;
                Upper.Add(Vowel[i].ToUpper());
                Lower.Add(Vowel[i]);
            }

            //Case for Constanants
            List<string> Constanants = new List<string>() 
            {"b","c","d","f","g","h","j","k","l","m","n","p","q","r","s","t","v","w","x","y","z"};
            for (int i = 0; i < Constanants.Count; i++)
            {
                values[2] += input.Split(Constanants[i]).Count() - 1;
                Upper.Add(Constanants[i].ToUpper());
                Lower.Add(Constanants[i]);

            }

            //Case for Uppercase
            for (int i = 0; i < Upper.Count; i++) 
            {
                values[3] += input.Split(Upper[i]).Count() - 1;
            }

            //Case for Lowercase
            for (int i = 0; i < Lower.Count; i++)
            {
                values[4] += input.Split(Lower[i]).Count() - 1;
            }

            return values;
        }
    }
}
