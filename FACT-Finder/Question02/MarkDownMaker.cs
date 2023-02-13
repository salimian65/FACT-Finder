using System;
using System.Linq;

namespace FACTFinder
{
    public class MarkDownMaker
    {
        public string HeadingMaker(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return "not correct format";
            }

            var items = input.Split(" ");

            if (items.Length == 1)
            {
                return "\"Header\" (no hashes)";
            }

            var hashesCount = items[0].Where(a => a == '#').ToList().Count;

            if (items[0].Length != hashesCount)
            {
                return "not correct format";
            }

            if (items.Length < 2)
            {
                return "not correct format";
            }

            if (items.Length > 2 && items[1] == "")
            {
                return $"\"{input}\" (too many spaces between)";
            }

            if (items.Length > 2)
            {
                return "not correct format";
            }


            if (items[0].Length > 6)
            {
                return $"\"{input}\" (too many hashes)";
            }

            return $"<h{hashesCount}>{items[1]}</h{hashesCount}>";
        }
    }
}