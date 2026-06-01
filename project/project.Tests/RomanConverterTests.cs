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

    [Fact]
    public void ConvertToRoman_WhenNumberIs19_ReturnsXIX()
    {
        // Arrange
        var converter = new RomanConverter();

        // Act
        var result = converter.ConvertToRoman(19);

        // Assert
        Assert.Equal("XIX", result);
    }

    [Fact]
    public void ConvertToRoman_WhenNumberIs50_ReturnsL()
    {
        // Arrange
        var converter = new RomanConverter();

        // Act
        var result = converter.ConvertToRoman(50);

        // Assert
        Assert.Equal("L", result);
    }

    [Fact]
    public void ConvertToRoman_WhenNumberIs99_ReturnsXCIX()
    {
        // Arrange
        var converter = new RomanConverter();
        // Act
        var result = converter.ConvertToRoman(99);
        // Assert
        Assert.Equal("XCIX", result);
    }

    [Fact]
    public void ConvertToRoman_WhenNumberIs1000_ReturnsM()
    {
        // Arrange
        var converter = new RomanConverter();
        // Act
        var result = converter.ConvertToRoman(1000);
        // Assert
        Assert.Equal("M", result);
    }
    
    [Fact]
    public void ConvertToRoman_WhenNumberIsNegative_ReturnsException()
    {
        // Arrange
        var converter = new RomanConverter();
        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => converter.ConvertToRoman(-1));
    }

    [Fact]
    public void ConvertToInteger_WhenRomanIsI_Returns1()
    {
        // Arrange
        var converter = new RomanConverter();
        // Act
        var result = converter.ConvertToInteger("I");
        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void ConvertToInteger_WhenRomanIsIV_Returns4()
    {
        // Arrange
        var converter = new RomanConverter();
        // Act
        var result = converter.ConvertToInteger("IV");
        // Assert
        Assert.Equal(4, result);
    }


    [Fact]
    public void ConvertToInteger_WhenRomanIsX_Returns10()
    {
        // Arrange
        var converter = new RomanConverter();
        // Act
        var result = converter.ConvertToInteger("X");
        // Assert
        Assert.Equal(10, result);
    }

    [Fact]
    public void ConvertToInteger_EmptyString_Returns0()
    {
        // Arrange
        var converter = new RomanConverter();
        // Act
        var result = converter.ConvertToInteger("");
        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void ConvertToInteger_WhenRomanIsIX_Returns9()
    {
        // Arrange
        var converter = new RomanConverter();
        // Act
        var result = converter.ConvertToInteger("IX");
        // Assert
        Assert.Equal(9, result);
    }

     [Fact]
    public void ConvertToInteger_WhenRomanIsL_Returns50()
    {
        // Arrange
        var converter = new RomanConverter();
        // Act
        var result = converter.ConvertToInteger("L");
        // Assert
        Assert.Equal(50, result);
    }

    [Fact]
    public void ConvertToInteger_WhenRomanIsCM_Returns900()
    {
        // Arrange
        var converter = new RomanConverter();
        // Act
        var result = converter.ConvertToInteger("CM");
        // Assert
        Assert.Equal(900, result);
    }

    [Fact]
    public void ConvertToInteger_WhenRomanIsM_Returns1000()
    {
        // Arrange
        var converter = new RomanConverter();
        // Act
        var result = converter.ConvertToInteger("M");
        // Assert
        Assert.Equal(1000, result);
    }
}
