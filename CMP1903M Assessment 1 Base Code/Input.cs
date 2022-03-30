using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "";
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            bool loop = true; 
            Console.WriteLine("Enter your sentences, use a '*' to enter your last one.");
            //loop runs until someone enters a * as their last character.
            while (loop == true)
            {
                Console.WriteLine("Enter your text:");
                text += " " + Console.ReadLine();
                if (text[text.Length - 1] == '*')
                {
                    loop = false;
                }
            }
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        { 
            text = File.ReadAllText(fileName);
            return text;           
        }

    }
}
