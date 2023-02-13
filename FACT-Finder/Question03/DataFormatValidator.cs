using System;

namespace FACTFinder
{
    public class DataFormatValidator : IFormatValidator
    {
        public bool IsValid(string value)
        {
            return DateTime.TryParse(value, out _);
        }
    }
}