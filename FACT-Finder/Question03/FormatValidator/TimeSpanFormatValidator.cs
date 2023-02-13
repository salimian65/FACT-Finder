using System;

namespace FACTFinder
{
    public class TimeSpanFormatValidator : IFormatValidator
    {
        public bool IsValid(string value)
        {
            return TimeSpan.TryParse(value, out _);
        }
    }
}