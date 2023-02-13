using FACTFinder;
using FluentAssertions;
using Xunit;

namespace Test
{
    public class Question01UnitTest
    {
        [Theory]
        [InlineData("test", "es")]
        [InlineData("testing", "t")]
        [InlineData("middle", "dd")]
        [InlineData("A", "A")]
        public void Get_Middle_format(string input, string expect)
        {
            //Arrange
            var sut = new StringHelper();
            //Act
            var result = sut.GetMiddle(input);
            // Assert
            result.Should().Be(expect);
        }
    }
}