using FACTFinder;
using FluentAssertions;
using Xunit;

namespace Test
{
    public class Question02UnitTest
    {
        [Theory]
        [InlineData("# Header", "<h1>Header</h1>")]
        [InlineData("## Header", "<h2>Header</h2>")]
        [InlineData("###### Header", "<h6>Header</h6>")]
        [InlineData("####### Header", "\"####### Header\" (too many hashes)")]
        [InlineData("######## Header", "\"######## Header\" (too many hashes)")]
        [InlineData("###  Header", "\"###  Header\" (too many spaces between)")]
        [InlineData("###   Header", "\"###   Header\" (too many spaces between)")]
        [InlineData("Header", "\"Header\" (no hashes)")]
        public void Get_Middle_format(string input, string expect)
        {
            //Arrange
            var sut = new MarkDownMaker();
            //Act
            var result = sut.HeadingMaker(input);
            // Assert
            result.Should().Be(expect);
        }
    }
}