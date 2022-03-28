﻿//Base code project for CMP1903M Assessment 1
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
            Input text = new Input();

            //Get either manually entered text, or text from a file
            Console.WriteLine("How would you like to enter your text?\n1) Keyboard \n2) File");
            int input = Convert.ToInt16(Console.ReadLine());
            if (input == 1)
            {
                text.manualTextInput();
            }
            else if (input == 2)
            {
                Console.WriteLine("enter your file name:"); 
                string fileName = Console.ReadLine();
                try
                {
                    text.fileTextInput(fileName);
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
