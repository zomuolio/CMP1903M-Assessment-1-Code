using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        public void outputConsole(List<int> values)
        {
            Console.WriteLine("Your string contained the following:");
            Console.WriteLine("Sentences:" + values[0]);
            Console.WriteLine("Vowels:" + values[1]);
            Console.WriteLine("Constanants:" + values[2]);
            Console.WriteLine("Upper Case:" + values[3]);
            Console.WriteLine("Lower Case" + values[4]);
        }



    }
}
