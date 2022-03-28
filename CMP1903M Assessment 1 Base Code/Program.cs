//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            Input Text = new Input();
            string text = "";

            //Get either manually entered text, or text from a file
            Console.WriteLine("How would you like to enter your text?\n1) Keyboard \n2) File");
            int choice = Convert.ToInt16(Console.ReadLine());
            if (choice == 1)
            {
                text = Text.manualTextInput();
            }
            else if (choice == 2)
            {
                Console.WriteLine("enter your file name:"); 
                string fileName = Console.ReadLine();
                try
                {
                    text = Text.fileTextInput(fileName);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e);
                }
            }
            else 
            {
                Console.WriteLine("not a valid input"); 
            }

            
            
            



            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?

           
        }   
    }
}
