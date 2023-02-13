using System;
using System.Collections.Generic;

namespace FACTFinder
{
    public class StringFormatValidator
    {
        public static bool IsFormat(string format, string value)
        {
            var allowedDict = new Dictionary<string, IFormatValidator>
            {
                {"number", new NumberFormatValidator()},
                {"date", new DataFormatValidator()},
                {"timespan", new TimeSpanFormatValidator()}
            };

            if (allowedDict.TryGetValue(format,out var formatValidator ))
            {
                return formatValidator.IsValid(value);
            }

            throw new Exception("Format not allowed");
        }
    }
}