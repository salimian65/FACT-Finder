using System;

namespace FACTFinder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //please check the test scenario
            // All 3 question have test scenario
            ////////////Question01////////////////////////////////////
            var StringHelperResult = new StringHelper().GetMiddle("middle");

            ////////////Question02////////////////////////////////////
            var markDownMakerEesult = new MarkDownMaker().HeadingMaker("###### Header");

            ////////////Question03////////////////////////////
            var numberResult = StringFormatValidator.IsFormat("number", "10");
            var numberResult1 = StringFormatValidator.IsFormat("number", "ww");
            var dateResult = StringFormatValidator.IsFormat("date", DateTime.Now.ToString());
            var timeSpanResult = StringFormatValidator.IsFormat("timespan", new TimeSpan(10, 15, 23).ToString());


            StringFormatValidator.IsFormat("float", "10");
            StringFormatValidator.IsFormat("decimal", DateTime.Now.ToString());
        }
    }
}