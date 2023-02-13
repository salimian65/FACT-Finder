using System;
using FACTFinder;
using FluentAssertions;
using Xunit;

namespace Test
{
    public class Question03UnitTest
    {
        [Fact]
        public void Number_is_format()
        {
            //Arrange
            //Act
            var result = StringFormatValidator.IsFormat("number", "10");
            //Assert
            result.Should().Be(true);
        }


        [Fact]
        public void Date_is_format()
        {
            //Arrange
            //Act
            var result = StringFormatValidator.IsFormat("date", DateTime.Now.ToString());
            //Assert
            result.Should().Be(true);
        }


        [Fact]
        public void Timespan_is_format()
        {
            //Arrange
            //Act
            var result = StringFormatValidator.IsFormat("timespan", new TimeSpan(10, 15, 23).ToString());
            //Assert
            result.Should().Be(true);
        }

        [Fact]
        public void Number_is_not_format()
        {
            //Arrange
            //Act
            var result = StringFormatValidator.IsFormat("number", "sss");
            //Assert
            result.Should().Be(false);
        }


        [Fact]
        public void Float_is_format()
        {
            //Arrange
            //Act
            var result = new Func<bool>(() => StringFormatValidator.IsFormat("float", "10"));
            //Assert
            result.Should().Throw<Exception>().WithMessage("Format not allowed");
        }


        [Fact]
        public void Decimal_is_format()
        {
            //Arrange
            //Act
            var result = new Func<bool>(() => StringFormatValidator.IsFormat("decimal", DateTime.Now.ToString()));
            //Assert
            result.Should().Throw<Exception>().Where(e => e.Message == "Format not allowed");
        }
    }
}