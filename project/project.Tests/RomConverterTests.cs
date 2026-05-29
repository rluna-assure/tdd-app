using project.Core;

namespace project.Tests;

public class RomanConverterTests
{
    [Fact]
    public void ConvertToRoman_WhenNumberIs1_ReturnsI()
    {
        // Arrange
        var converter = new RomanConverter();

        // Act
        var result = converter.ConvertToRoman(1);

        // Assert
        Assert.Equal("I", result);
    }

    [Fact]
    public void ConvertToRoman_WhenNumberIs3_ReturnsIII()
    {
        // Arrange
        var converter = new RomanConverter();

        // Act
        var result = converter.ConvertToRoman(3);

        // Assert
        Assert.Equal("III", result);
    }

    [Fact]
    public void ConvertToRoman_WhenNumberIs4_ReturnsIV()
    {
        // Arrange
        var converter = new RomanConverter();

        // Act
        var result = converter.ConvertToRoman(4);

        // Assert
        Assert.Equal("IV", result);
    }
}
