using ToyFactoryLibrary;
using ToyFactoryLibrary.Enums;
using Xunit;

namespace ToyFactoryTests.ToyBlockTests
{
    public class SquareTests 
    {
        [Theory]
        [InlineData(Colour.Blue)]
        [InlineData(Colour.Red)]
        [InlineData(Colour.Yellow)]
        public void ToyBlock_test_set_Colour(Colour expected)
        {
            // Arrange
            var square = new Square(expected);
            
            // Act 

            // Assert
            Assert.Equal(expected, square.Colour);
        }
        
    }
}