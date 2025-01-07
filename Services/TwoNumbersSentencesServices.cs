using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoToFour.Services
{
    public class TwoNumbersSentencesServices
    {
        public string statement = "";
        public string ComparedNumbers(int num1, int num2)
        {
            
            
            
            if (num1 > num2)
            {
                statement = "Your first number " + num1 + " is greater than your second number " + num2 + "." + " Your second number " + num2 + " is less than your first number " + num1 + ".";
                
            }

            else if (num2 > num1)
            {
                statement = "Your first number " + num1 + " is less than your second number " + num2 + "." + " Your second number " + num2 + " is greater than your first number " + num1 + ".";
                
            }

            else if (num1 == num2)
            {
                statement = "Your first number " + num1 + " is equal to your second number " + num2 + "." + " Your second number " + num2 + " is equal to your first number " + num1 + ".";
                
            }
            return statement;
        }
    }
}