using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzLibrary
{
    public class FizzBuzz
    {
        private int FizzNumber = 3;
        private int BuzzNumber = 5;

        public String Count(int countInput)
        {
            string countString = string.Empty;
            if (IsFizzNumber(countInput) && IsBuzzNumber(countInput))
            {
                countString = "FizzBuzz";
            }
            else if (IsFizzNumber(countInput))
            {
                countString = "Fizz";
            }
            else if (IsBuzzNumber(countInput))
            {
                countString = "Buzz";
            }
            else
            {
                countString = countInput.ToString();
            }
            return countString;
        }

        private bool IsBuzzNumber(int countInput)
        {
            return countInput % BuzzNumber == 0;
        }

        private bool IsFizzNumber(int countInput)
        {
            return countInput % FizzNumber == 0;
        }
    }
}
