using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {

        ////Method: outputConsole
        //Arguments: List of integers
        //Returns: Void
        //Handles the reporting of the analysis via console output.
        public void outputConsole(List<int> values,List<int> Letters)
        {
            List<string> alphabet = new List<string>()
            { 
              "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
              "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" 
            };

            Console.WriteLine("Your string contained the following:");
            Console.WriteLine("Sentences:" + values[0]);
            Console.WriteLine("Vowels:" + values[1]);
            Console.WriteLine("Constanants:" + values[2]);
            Console.WriteLine("Upper Case:" + values[3]);
            Console.WriteLine("Lower Case" + values[4]);

            Console.WriteLine("The frequency at which letters appear is:");

            for (int i = 0; i < Letters.Count; i++)
            {
                 Console.WriteLine(alphabet[i] + " apears " + Letters[i] + " times in the text.");
            }

        }
    }
}
