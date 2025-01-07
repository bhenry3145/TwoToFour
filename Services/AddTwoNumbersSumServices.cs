using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoToFour.Services
{
    public class AddTwoNumbersSumServices
    {
        public string sum = "";
         public string AddNumbers(int num1, int num2)
        {
            sum = "The sum of " + num1.ToString() + " and " + num2.ToString() + " is equal to " + (num1 + num2).ToString();
            return sum;
        }
    }
}