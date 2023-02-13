using System;

namespace FACTFinder
{
    public class StringHelper
    {
        public string GetMiddle(string input)
        {
            if (input.Length < 0 || input.Length > 1000)
            {
                throw new Exception("the input isn't valid");
            }

            var reminder = input.Length % 2;
            var index = (input.Length / 2) - 1 + reminder;
            var length = reminder == 1 ? 1 : 2;
            return input.Substring(index, length);
        }
    }
}