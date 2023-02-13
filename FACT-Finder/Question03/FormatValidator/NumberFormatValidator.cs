namespace FACTFinder
{
    public class NumberFormatValidator : IFormatValidator
    {
        public bool IsValid(string value)
        {
            return int.TryParse(value, out _);
        }
    }
}